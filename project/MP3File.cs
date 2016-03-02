using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;
using System.Threading.Tasks;

namespace iPodEmulator
{
    class MP3File
    {
        public string Path
        {
            get
            {
                return _path;
            }
        }

        public Tag Tags
        {
            get
            {
                return _tags;
            }
        }


        public MP3File(string path)
        {
            _path = path; // for save case
            if (!MP3Api.isValidFile(path))
                return;

            _tags = TagLib.File.Create(path).Tag;
        }

        private Tag _tags;
        private string _path;
    }
}
