using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPodEmulator
{
    class MP3Editor
    {
        public bool saveLyrics(MP3File file, string lyrics) {
            return MP3Api.saveLyrics(file.Path, lyrics);
        }

        public bool saveCover(MP3File file, string coverPath)
        {
            return MP3Api.saveCover(file.Path, coverPath);
        }

        public bool saveTitle(MP3File file, string title)
        {
            return MP3Api.saveTitle(file.Path, title);
        }
    }
}
