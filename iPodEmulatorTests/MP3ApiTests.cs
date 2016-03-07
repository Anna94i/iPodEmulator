using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iPodEmulator;
using System.IO;

namespace iPodEmulatorTests
{
    [TestClass]
    public class MP3ApiTests
    {
        [TestMethod]
        public void saveLyricsTest()
        {
            string expected = "Song`s text";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveLyrics(file.Path, "Song`s text");
            string actual = (new MP3File("song.mp3")).Tags.Lyrics;
            Assert.AreEqual(expected, actual, "Lyrics is not saved correctly");
        }

        //error here
        [TestMethod]
        public void saveEmptyLyricsTest()
        {
            string expected = "";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveLyrics(file.Path, "");
            string actual = (new MP3File("song.mp3")).Tags.Lyrics;
            Assert.AreEqual(expected, actual, "Lyrics doesn`t save correctly");
        }

        [TestMethod]
        public void saveTitleTest()
        {
            string expected = "My title";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveTitle(file.Path, "My title");
            string actual = (new MP3File("song.mp3")).Tags.Title;
            Assert.AreEqual(expected, actual, "Title is not saved correctly");
        }

        //error here
        [TestMethod]
        public void saveEmptyTitleTest()
        {
            string expected = "";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveTitle(file.Path, "");
            string actual = (new MP3File("song.mp3")).Tags.Title;
            Assert.AreEqual(expected, actual, "Empty title is not saved correctly");
        }

        [TestMethod]
        public void saveAlbumTitleTest()
        {
            string expected = "My album title";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveAlbumTitle(file.Path, "My album title");
            string actual = (new MP3File("song.mp3")).Tags.Album;
            Assert.AreEqual(expected, actual, "Album title is not saved correctly");
        }

        [TestMethod]
        public void saveArtistNameTest()
        {
            string expected = "My artist";
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveArtistName(file.Path, "My artist");
            string actual = (new MP3File("song.mp3")).Tags.AlbumArtists[(new MP3File("song.mp3")).Tags.AlbumArtists.Length - 1];
            Assert.AreEqual(expected, actual, "Artist is not saved correctly");
        }

        [TestMethod]
        public void saveCoverTest()
        {
            int expected = 1;
            MP3File file = new MP3File("song.mp3");
            MP3Api.saveCover(file.Path, "cover.jpg");
            int actual = (new MP3File("song.mp3")).Tags.Pictures.Length;
            Assert.AreEqual(expected, actual, "Cover is not saved correctly");
        }

    }
}
