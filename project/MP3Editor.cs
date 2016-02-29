using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPodEmulator
{
    class MP3Editor
    {

        public MP3File File
        {
            get
            {
                return _file;
            }
        }

        public MP3Editor(MP3File file)
        {
            _file = file;
        }

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

        private MP3File _file;
    }
}
