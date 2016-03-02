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
        }

        public MP3Editor(MP3File file)
        {
            _isDefault = false;
            _file = file;
        }


        //--------------------------save part---------------------------
        public bool saveLyrics(string lyrics) 
        {
            return MP3Api.saveLyrics(_file.Path, lyrics);
        }

        public bool saveAlbumTitle(string title)
        {
            return MP3Api.saveAlbumTitle(_file.Path, title);
        }

        public bool saveArtistName(string name)
        {
            return MP3Api.saveArtistName(_file.Path, name);
        }

        public bool saveBlackCover()
        {
            return MP3Api.saveCover(_file.Path, "black.jpg");
        }

        public bool saveTitle(string title)
        {
            return MP3Api.saveTitle(_file.Path, title);
        }


        //-----------------------------------file operations--------------------

        public void deleteFile()
        {
            System.IO.File.Delete(_file.Path);
        }

        public void cutFileTo(string path)
        {
            System.IO.File.Copy(_file.Path, path, true);
            deleteFile();
            _file = new MP3File(path);
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

        private const string _defaultSongName = "song.mp3";
    }
}
