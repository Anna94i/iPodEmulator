﻿using System;
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
            makeClearView();
            _config.prepareTextView(textView);

            _editor = new MP3Editor();

            hideIpodButtons();
        }

        private void hideIpodButtons()
        {
            //turn on
            turnOnButtonRectangle = turnOnButton.Bounds;
            turnOnButton.Visible = false;
        }

        /// <summary>
        /// Default view
        /// </summary>
        private void makeClearView()
        {
            textView.Text = _config.LyricsPlaceholder;
            artistNameTextBox.Text = _config.ArtistPlaceholder;
            songTitleTextBox.Text = _config.TitlePlaceholder;
            albumTitleTextBox.Text = _config.AlbumPlaceholder;
            iPodScreen.Location = new Point(
                 this.ClientSize.Width / 2 - iPodScreen.Size.Width / 2,
                 this.ClientSize.Height / 2 - iPodScreen.Size.Height / 2 - 15);
            iPodScreen.Anchor = AnchorStyles.None;
        }

        //------------------------------Menu---------------------------------

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeToolStripMenuItem_Click(sender, e);

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Music Files (.mp3)|*.mp3";
            fd.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userResult = fd.ShowDialog();

            // Process input if the user clicked OK.
            if (userResult == DialogResult.OK)
            {
                _editor = new MP3Editor(new MP3File(fd.FileName));
                showScreen();
                loadFileFromEditor();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_editor.needBeSaved)
            {
                showSaveMessageBox();
            }

            hideScreen();
        }

        private void loadFileFromEditor()
        {
            MP3File file = _editor.File;
            textView.Text = file.Tags.Lyrics;
            artistNameTextBox.Text = file.Tags.FirstPerformer;
            songTitleTextBox.Text = file.Tags.Title;
            albumTitleTextBox.Text = file.Tags.Album;
        }

        private void saveAll()
        {

            _editor.saveAlbumTitle(albumTitleTextBox.Text);
            _editor.saveArtistName(artistNameTextBox.Text);
            _editor.saveBlackCover();
            _editor.saveLyrics(textView.Text);
            _editor.saveTitle(songTitleTextBox.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_editor.isDefault)
            {
                saveWithFileDialog();
            }

            saveAll();
        }

        private void saveWithFileDialog()
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Music Files (.mp3)|*.mp3";
            fd.FilterIndex = 1;

            DialogResult userResult = fd.ShowDialog();

            if (userResult == DialogResult.OK)
            {
                saveAll();
                _editor.cutFileTo(fd.FileName);
            } 

            if (userResult == DialogResult.No)
            {
                _editor.deleteTempFile();
            }
        }

        private void showSaveMessageBox()
        {
            DialogResult result = MessageBox.Show("File is not saved. Save it for you?", "Close", MessageBoxButtons.YesNoCancel);

            if (result == System.Windows.Forms.DialogResult.Yes
                || result == System.Windows.Forms.DialogResult.No)
            {
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    saveWithFileDialog();
                }

                _editor = new MP3Editor();
                makeClearView();
            }
        }


        //----------------------------Textboxes logic----------------------------

        private void artistNameTextBox_Leave(object sender, EventArgs e)
        {
            _editor.saveArtistName(artistNameTextBox.Text);
        }

        private void songTitleTextBox_Leave(object sender, EventArgs e)
        {
            _editor.saveTitle(songTitleTextBox.Text);
        }

        private void albumTitleTextBox_Leave(object sender, EventArgs e)
        {
            _editor.saveAlbumTitle(albumTitleTextBox.Text);
        }

        private void textView_Leave(object sender, EventArgs e)
        {
            _editor.saveLyrics(textView.Text);
        }

        private void songTitleTextBox_Click(object sender, EventArgs e)
        {
            if (songTitleTextBox.Text == _config.TitlePlaceholder)
            {
                songTitleTextBox.Text = "";
            }
        }

        private void albumTitleTextBox_Click(object sender, EventArgs e)
        {
            if (albumTitleTextBox.Text == _config.AlbumPlaceholder)
            {
                albumTitleTextBox.Text = "";
            }
        }

        private void artistNameTextBox_Click(object sender, EventArgs e)
        {
            if (artistNameTextBox.Text == _config.ArtistPlaceholder)
            {
                artistNameTextBox.Text = "";
            }
        }

        private void textView_Click(object sender, EventArgs e)
        {
            if (textView.Text == _config.LyricsPlaceholder) 
            {
                textView.Text = "";
            }
        }

        private void textView_TextChanged(object sender, EventArgs e)
        {
            _config.calibrateTextView(textView);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showScreen();
            _editor = new MP3Editor();
            makeClearView();
        }

        //----------------------------ipod buttons logic------------------------------

        private void turnOnButton_Click(object sender, EventArgs e)
        {
            if (textView.Visible)
                hideScreen();
            else
                showScreen();
        }

        private void switchScreen()
        {
            bool visibleValue = !textView.Visible;
            artistNameTextBox.Visible = visibleValue;
            songTitleTextBox.Visible = visibleValue;
            albumTitleTextBox.Visible = visibleValue;
            textView.Visible = visibleValue;
        }

        private void hideScreen()
        {
            Color backgroundColor = Color.FromArgb(102, 102, 102);
            iPodScreen.BackColor = backgroundColor;
            if (textView.Visible)
                switchScreen();
        }

        private void showScreen()
        {
            iPodScreen.BackColor = Color.Black;
            if (!textView.Visible)
                switchScreen();
        }


        private void ipodPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (turnOnButtonRectangle.Contains(new Point(e.X, e.Y)))
                turnOnButton_Click(turnOnButton, new EventArgs());
        }

        private Rectangle turnOnButtonRectangle;

        private void TextEditorForm_Shown(object sender, EventArgs e)
        {
            hideScreen();
        }

    }
}
