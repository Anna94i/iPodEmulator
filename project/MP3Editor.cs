using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iPodEmulator
{
    class MP3Editor
    {
        public bool needBeSaved
        {
            get
            {
                return _needBeSaved && _isDefault;
            }
        }

        public bool isDefault
        {
            get
            {
                return _isDefault;
            }
        }

        public MP3File File
        {
            get
            {
                return _file;
            }
        }

        public MP3Editor()
        {
            _isDefault = true;
            _file = new MP3File(makeDefaultFileCopy());
            _needBeSaved = false;
        }

        public MP3Editor(MP3File file)
        {
            _isDefault = false;
            _file = file;
            _needBeSaved = false;
        }


        //--------------------------save part---------------------------
        public bool saveLyrics(string lyrics) 
        {
            _needBeSaved = true;
            return MP3Api.saveLyrics(_file.Path, lyrics);
        }

        public bool saveAlbumTitle(string title)
        {
            _needBeSaved = true;
            return MP3Api.saveAlbumTitle(_file.Path, title);
        }

        public bool saveArtistName(string name)
        {
            _needBeSaved = true;
            return MP3Api.saveArtistName(_file.Path, name);
        }

        public bool saveBlackCover()
        {
            _needBeSaved = true;
            return MP3Api.saveCover(_file.Path, "black.jpg");
        }

        public bool saveTitle(string title)
        {
            _needBeSaved = true;
            return MP3Api.saveTitle(_file.Path, title);
        }


        //-----------------------------------file operations--------------------

        public void cutFileTo(string path)
        {
            System.IO.File.Copy(_file.Path, path, true);
            deleteTempFile();
            _file = new MP3File(path);
            _isDefault = false;
            _needBeSaved = false;
        }

        public void deleteTempFile()
        {
            if (isDefault)
                System.IO.File.Delete(_file.Path);
        }

        private string getDefaultSongPath()
        {
            string[] resources = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            for (int i = 0; i < resources.Length; i++)
            {
                if (resources[i].IndexOf(_defaultSongName) >= 0)
                {
                    return resources[i];
                }
            }

            return _defaultSongName;
        }

        private string makeDefaultFileCopy()
        {
            string targetDir = Path.GetTempPath();
            string resPath = System.IO.Path.Combine(targetDir, _defaultSongName);
            using (System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(getDefaultSongPath()))
            {
                using (System.IO.FileStream fileStream = new System.IO.FileStream(resPath, System.IO.FileMode.Create))
                {
                    for (int i = 0; i < stream.Length; i++)
                    {
                        fileStream.WriteByte((byte)stream.ReadByte());
                    }
                    fileStream.Close();
                }
            }

            return resPath;
        }

        private MP3File _file;
        private bool _isDefault;
        private bool _needBeSaved; //file was modified

        private const string _defaultSongName = "song.mp3";
    }
}
