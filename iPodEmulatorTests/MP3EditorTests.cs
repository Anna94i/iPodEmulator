using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iPodEmulator;
using System.Collections.Generic;

namespace iPodEmulatorTests
{
    [TestClass]
    public class MP3EditorTests
    {
        [TestMethod]
        public void saveLyricsTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            bool actual = editor.saveLyrics("Text text");
            string actualText = (new MP3File("song.mp3")).Tags.Lyrics;
            Assert.AreEqual(expected, actual, "Lyrics is not saved correctly");
            Assert.AreEqual("Text text", actualText, "Lyrics is not saved correctly");
        }

        [TestMethod]
        public void saveTitleTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            bool actual = editor.saveTitle("My title");
            string actualTitle = (new MP3File("song.mp3")).Tags.Title;
            Assert.AreEqual(expected, actual, "Title is not saved correctly");
            Assert.AreEqual("My title", actualTitle, "Title is not saved correctly");
        }

        [TestMethod]
        public void saveAlbumTitleTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            bool actual = editor.saveAlbumTitle("My album title");
            string actualTitle = (new MP3File("song.mp3")).Tags.Album;
            Assert.AreEqual(expected, actual, "Album title is not saved correctly");
            Assert.AreEqual("My album title", actualTitle, "Album title is not saved correctly");
        }

        [TestMethod]
        public void saveArtistNameTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            bool actual = editor.saveArtistName("Artist");
            bool actualArtist = (new List<string>((new MP3File("song.mp3")).Tags.AlbumArtists)).Contains("Artist");
            Assert.AreEqual(expected, actual, "Artist is not saved correctly");
            Assert.AreEqual(true, actualArtist, "Artist is not saved correctly");
        }

        [TestMethod]
        public void saveCoverTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            bool actual = editor.saveBlackCover();
            int actualCoversNum = (new MP3File("song.mp3")).Tags.Pictures.Length;
            Assert.AreEqual(expected, actual, "Cover is not saved correctly");
            Assert.AreEqual(1, actualCoversNum, "Cover is not saved correctly");
        }

        [TestMethod]
        public void cutFileToTest()
        {
            string expected = "song1.mp3";
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            editor.cutFileTo("song1.mp3");
            string actual = editor.File.Path;
            Assert.AreEqual(expected, actual, "cutFileTo method does not work correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void cutFileToTest2()
        {
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            editor.cutFileTo("");
        }

        [TestMethod]
        public void deleteTempFileTest()
        {
            bool expected = true;
            MP3File file = new MP3File("song.mp3");
            MP3Editor editor = new MP3Editor(file);
            editor.deleteTempFile();
            bool actual = System.IO.File.Exists("song.mp3");
            Assert.AreEqual(expected, actual, "deleteTempFile method does not work correctly");
        }

        [TestMethod]
        public void deleteTempFileTest2()
        {
            bool expected = false;
            MP3Editor editor = new MP3Editor();
            string filePath = editor.File.Path;
            editor.deleteTempFile();
            bool actual = System.IO.File.Exists(filePath);
            Assert.AreEqual(expected, actual, "deleteTempFile method does not work correctly");
        }
    }
}
