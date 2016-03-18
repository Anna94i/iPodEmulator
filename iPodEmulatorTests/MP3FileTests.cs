using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iPodEmulator;

namespace iPodEmulatorTests
{
    [TestClass]
    public class MP3FileTests
    {
        /// <summary>
        /// Basic constructor test
        /// </summary>
        [TestMethod]
        public void constructorTest()
        {
            string expected = "song.mp3";
            MP3File file = new MP3File("song.mp3");
            string actual = file.Path;
            Assert.AreEqual(expected, actual, "MP3File constructor does not work correctly");
            Assert.AreNotEqual(null, file.Tags, "MP3File constructor does not work correctly");
        }

        /// <summary>
        /// Constructor test for not existing file
        /// </summary>
        [TestMethod]
        public void constructorNullTagsTest()
        {
            string expected = "my_song.mp3";
            MP3File file = new MP3File("my_song.mp3");
            string actual = file.Path;
            Assert.AreEqual(expected, actual, "MP3File constructor does not work correctly");
            Assert.AreEqual(null, file.Tags, "MP3File constructor does not work correctly");
        }

        /// <summary>
        /// Constructor test for empty file name
        /// </summary>
        [TestMethod]
        public void constructorEmptyPathTest()
        {
            string expected = "";
            MP3File file = new MP3File("");
            string actual = file.Path;
            Assert.AreEqual(expected, actual, "MP3File constructor does not work correctly");
            Assert.AreEqual(null, file.Tags, "MP3File constructor does not work correctly");
        }
    }
}
