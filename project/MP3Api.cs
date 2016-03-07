using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.IO;

namespace iPodEmulator
{

    enum MP3APITag
    {
        Lyrics,
        Title, 
        Artist, 
        Cover,
        AlbumTitle
    }

    //low-level API
    static class MP3Api
    {
        static public bool saveLyrics(string path, string lyrics) {
            return saveTag(path, MP3APITag.Lyrics, lyrics);
        }

        static public bool saveTitle(string path, string title)
        {
            return saveTag(path, MP3APITag.Title, title);
        }

        static public bool saveAlbumTitle(string path, string title)
        {
            return saveTag(path, MP3APITag.AlbumTitle, title);
        }

        static public bool saveArtistName(string path, string name)
        {
            return saveTag(path, MP3APITag.Artist, name);
        }

        static public bool saveCover(string path, string coverPath)
        {
            return saveTag(path, MP3APITag.Cover, coverPath);
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
        static private bool saveTag(string path, MP3APITag tag, string value)
        {
            if (!isFileExists(path))
                return false;

            using (TagLib.File f = TagLib.File.Create(path))
            {
                switch (tag)
                {
                    case MP3APITag.Lyrics:
                        f.Tag.Lyrics = value;
                        break;
                    case MP3APITag.Title:
                        f.Tag.Title = value;
                        break;
                    case MP3APITag.Cover:
                        if (!isFileExists(value))
                            return false;
                        TagLib.Id3v2.AttachedPictureFrame cover = getCoverImage(path);
                        f.Tag.Pictures = new TagLib.IPicture[1] { cover };    
                        break;
                    case MP3APITag.Artist:
                        f.Tag.AlbumArtists = new string[1] { value };
                        break;
                    case MP3APITag.AlbumTitle:
                        f.Tag.Album = value;
                        break;
                }
                f.Save();
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
