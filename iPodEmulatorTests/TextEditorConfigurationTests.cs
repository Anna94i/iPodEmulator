using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iPodEmulator;
using System.Windows.Forms;

namespace iPodEmulatorTests
{
    [TestClass]
    public class TextEditorConfigurationTests
    {
        /// <summary>
        /// Test for prepareTextView method of TextEditorConfiguration class
        /// </summary>
        [TestMethod]
        public void prepareTextViewTest()
        {
            RichTextBox textBox = new RichTextBox();
            TextEditorConfiguration config = new TextEditorConfiguration();

            float currSize = textBox.Font.Size; 
            float textConst = 0.89F; 
            int ipodLineSymbolsCount = 27;
            int textViewLineSymbolsCount = 39; 

            float fontSize = ((textViewLineSymbolsCount * currSize) / ipodLineSymbolsCount) * textConst;

            config.prepareTextView(textBox);

            Assert.AreEqual(9, textBox.SelectionIndent, "prepareTextView method does not work correctly. SelectionIndent is not correct");
            Assert.AreEqual(9, textBox.SelectionRightIndent, "prepareTextView method does not work correctly. SelectionRightIndent is not correct");
            Assert.AreEqual(0, textBox.SelectionLength, "prepareTextView method does not work correctly. SelectionLength is not correct");
            Assert.AreEqual(fontSize, textBox.Font.Size, "prepareTextView method does not work correctly. Font size is not correct");
        }

        /// <summary>
        /// Test for calibrateTextView method of TextEditorConfiguration class
        /// </summary>
        [TestMethod]
        public void calibrateTextViewTest()
        {
            RichTextBox textBox = new RichTextBox();
            int expected = textBox.SelectionStart;
            TextEditorConfiguration config = new TextEditorConfiguration();

            config.calibrateTextView(textBox);

            Assert.AreEqual(9, textBox.SelectionIndent, "prepareTextView method does not work correctly. SelectionIndent is not correct");
            Assert.AreEqual(9, textBox.SelectionRightIndent, "prepareTextView method does not work correctly. SelectionRightIndent is not correct");
            Assert.AreEqual(0, textBox.SelectionLength, "prepareTextView method does not work correctly. SelectionLength is not correct");
            Assert.AreEqual(expected, textBox.SelectionStart, "prepareTextView method does not work correctly. SelectionStart is not correct");
        }

        /// <summary>
        /// Test for calibrateTextView method of TextEditorConfiguration class after adding some text to RichTextBox
        /// </summary>
        [TestMethod]
        public void calibrateTextViewTest2()
        {
            RichTextBox textBox = new RichTextBox();
            textBox.Text = "Text";
            int expected = textBox.SelectionStart;
            TextEditorConfiguration config = new TextEditorConfiguration();

            config.calibrateTextView(textBox);

            Assert.AreEqual(9, textBox.SelectionIndent, "prepareTextView method does not work correctly. SelectionIndent is not correct");
            Assert.AreEqual(9, textBox.SelectionRightIndent, "prepareTextView method does not work correctly. SelectionRightIndent is not correct");
            Assert.AreEqual(0, textBox.SelectionLength, "prepareTextView method does not work correctly. SelectionLength is not correct");
            Assert.AreEqual(expected, textBox.SelectionStart, "prepareTextView method does not work correctly. SelectionStart is not correct");
        }
    }
}
