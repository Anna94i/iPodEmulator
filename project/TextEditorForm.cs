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
        private TextEditorConfiguration _config;
        private MP3Editor _editor;

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Music Files (.mp3)|*.mp3";
            fd.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userResult = fd.ShowDialog();

            // Process input if the user clicked OK.
            if (userResult == DialogResult.OK)
            {
                _editor = new MP3Editor(new MP3File(fd.FileName));
                loadFileFromEditor();
            }
        }

        private void loadFileFromEditor() 
        {
            MP3File file = _editor.File;
            textView.Text = file.Tags.Lyrics;
            songTitleLabel.Text = file.Tags.Title;
            albumTitleLabel.Text = file.Tags.Album;
            artistNameLabel.Text = file.Tags.FirstPerformer;
        }

        private void makeClearView()
        {
            textView.Text = "Lyrics goes here";
            songTitleLabel.Text = "Song title";
            albumTitleLabel.Text = "Album title";
            artistNameLabel.Text = "Artist goes here";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: check for null
            _editor.saveTitle(songTitleLabel.Text);
            _editor.saveLyrics(textView.Text);
            //TODO: save anothers
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: check for save
            _editor = null;
        }
    }
}
