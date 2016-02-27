using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.IO;

namespace iPodEmulator
{
    //low-level API
    static class MP3Api
    {
        static public bool saveLyrics(string path, string lyrics) {
            return saveTag(path, "lyrics", lyrics);
        }

        static public bool saveTitle(string path, string title)
        {
            return saveTag(path,"title", title);
        }

        static public bool saveCover(string path, string coverPath)
        {
            return saveTag(path, "cover", coverPath);
        }

        static public bool isValidFile(string path)
        {
            if (!isFileExists(path))
                return false;

            string extension = Path.GetExtension(path);
            if (extension != ".mp3")
                return false;

            return true;
        }

        //sets value to tag
        //possible tags: lyrics, title, cover
        static private bool saveTag(string path, string tag, string value)
        {
            if (!isFileExists(path))
                return false;

            using (TagLib.File f = TagLib.File.Create(path))
            {
                switch (tag)
                {
                    case "lyrics":
                        f.Tag.Lyrics = value;
                        break;
                    case "title":
                        f.Tag.Lyrics = value;
                        break;
                    case "cover":
                        if (!isFileExists(value))
                            return false;
                        TagLib.Id3v2.AttachedPictureFrame cover = getCoverImage(path);
                        f.Tag.Pictures = new TagLib.IPicture[1] { cover };    
                        break;
                }
            }

            return true;
        }

        static private TagLib.Id3v2.AttachedPictureFrame getCoverImage(string path)
        {
            TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
            pic.TextEncoding = TagLib.StringType.Latin1;
            pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
            pic.Type = TagLib.PictureType.FrontCover;
            pic.Data = TagLib.ByteVector.FromPath(path);

            return pic;
        }

        static private bool isFileExists(string path)
        {
            return System.IO.File.Exists(path);
        }
    }
}
