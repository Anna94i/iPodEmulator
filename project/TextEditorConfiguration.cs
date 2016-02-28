using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace iPodEmulator
{
    class TextEditorConfiguration
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
            textView.Font = new Font("Arial", fontSize);
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
        }
    }
}
