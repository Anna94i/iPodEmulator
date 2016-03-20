using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace iPodEmulator
{
    public class TextEditorConfiguration
    {
        public void prepareTextView(RichTextBox textView) {
            //margins
            textView.SelectAll();
            textView.SelectionIndent = 9;
            textView.SelectionRightIndent = 9;
            textView.SelectionLength = 0;
            textView.SelectionBackColor = textView.BackColor;
            
            //params
            float currSize = textView.Font.Size; //default text size
            float textConst = 0.89F; //magic const
            int ipodLineSymbolsCount = 27; //how many symbols fiited in ipod line
            int textViewLineSymbolsCount = 39; //textview line

            // get new size
            float fontSize = ((textViewLineSymbolsCount * currSize) / ipodLineSymbolsCount) * textConst;
            

            //set new font
            goodFont = new Font("Arial", fontSize);
            textView.Font = goodFont;

            textView.SelectionStart = textView.Text.Length;
        }

        public void calibrateTextView(RichTextBox textView)
        {
            int i = textView.SelectionStart;

            //margins
            textView.SelectAll();
            textView.SelectionIndent = 9;
            textView.SelectionRightIndent = 9;
            textView.SelectionLength = 0;
            textView.SelectionBackColor = textView.BackColor;

            textView.SelectionStart = i;

            if (goodFont != null) {
                textView.Font = goodFont;

                //winforms bag. If new forecolor is equal to old the text will not be redraw.
                textView.ForeColor = Color.Gold;
                textView.ForeColor = Color.White;
            }
        }

        public string LyricsPlaceholder
        {
            get
            {
                return _lyricsPlaceholder;
            }
        }

        public string TitlePlaceholder
        {
            get
            {
                return _titlePlaceholder;
            }
        }

        public string AlbumPlaceholder
        {
            get
            {
                return _albumPlaceholder;
            }
        }

        public string ArtistPlaceholder
        {
            get
            {
                return _artistPlaceholder;
            }
        }

        //good font for view
        private Font goodFont = null;

        private string _lyricsPlaceholder = "Lyrics goes here";
        private string _titlePlaceholder = "Title";
        private string _albumPlaceholder = "One more text";
        private string _artistPlaceholder = "Some text";
    }
}
