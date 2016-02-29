using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPodEmulator
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
            _config = new TextEditorConfiguration();

            _config.prepareTextView(textView);
        }

        private void textView_TextChanged(object sender, EventArgs e)
        {
            _config.calibrateTextView(textView);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }


        private TextEditorConfiguration _config;
    }
}
