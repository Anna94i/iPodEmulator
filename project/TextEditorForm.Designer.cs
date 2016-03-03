namespace iPodEmulator
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textView = new System.Windows.Forms.RichTextBox();
            this.ipodEditorMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistNameTextBox = new System.Windows.Forms.TextBox();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.textEditorPanel = new System.Windows.Forms.Panel();
            this.turnOnButton = new System.Windows.Forms.Button();
            this.iPodScreen = new System.Windows.Forms.Panel();
            this.ipodPicture = new System.Windows.Forms.PictureBox();
            this.ipodEditorMenu.SuspendLayout();
            this.textEditorPanel.SuspendLayout();
            this.iPodScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textView
            // 
            this.textView.BackColor = System.Drawing.Color.Black;
            this.textView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textView.Dock = System.Windows.Forms.DockStyle.Top;
            this.textView.ForeColor = System.Drawing.Color.White;
            this.textView.Location = new System.Drawing.Point(0, 99);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(478, 410);
            this.textView.TabIndex = 0;
            this.textView.Text = "";
            this.textView.Click += new System.EventHandler(this.textView_Click);
            this.textView.TextChanged += new System.EventHandler(this.textView_TextChanged);
            this.textView.Leave += new System.EventHandler(this.textView_Leave);
            // 
            // ipodEditorMenu
            // 
            this.ipodEditorMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ipodEditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ipodEditorMenu.Location = new System.Drawing.Point(0, 0);
            this.ipodEditorMenu.Name = "ipodEditorMenu";
            this.ipodEditorMenu.Size = new System.Drawing.Size(656, 40);
            this.ipodEditorMenu.TabIndex = 1;
            this.ipodEditorMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.BackColor = System.Drawing.Color.Black;
            this.albumTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumTitleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.albumTitleTextBox.Location = new System.Drawing.Point(0, 68);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(478, 31);
            this.albumTitleTextBox.TabIndex = 2;
            this.albumTitleTextBox.Text = "One more text";
            this.albumTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.albumTitleTextBox.Click += new System.EventHandler(this.albumTitleTextBox_Click);
            this.albumTitleTextBox.Leave += new System.EventHandler(this.albumTitleTextBox_Leave);
            // 
            // artistNameTextBox
            // 
            this.artistNameTextBox.BackColor = System.Drawing.Color.Black;
            this.artistNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.artistNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistNameTextBox.ForeColor = System.Drawing.Color.White;
            this.artistNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.artistNameTextBox.Name = "artistNameTextBox";
            this.artistNameTextBox.Size = new System.Drawing.Size(478, 31);
            this.artistNameTextBox.TabIndex = 3;
            this.artistNameTextBox.Text = "Some text";
            this.artistNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.artistNameTextBox.Click += new System.EventHandler(this.artistNameTextBox_Click);
            this.artistNameTextBox.Leave += new System.EventHandler(this.artistNameTextBox_Leave);
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.BackColor = System.Drawing.Color.Black;
            this.songTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songTitleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.songTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.songTitleTextBox.Location = new System.Drawing.Point(0, 31);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(478, 37);
            this.songTitleTextBox.TabIndex = 4;
            this.songTitleTextBox.Text = "Title";
            this.songTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.songTitleTextBox.Click += new System.EventHandler(this.songTitleTextBox_Click);
            this.songTitleTextBox.Leave += new System.EventHandler(this.songTitleTextBox_Click);
            // 
            // textEditorPanel
            // 
            this.textEditorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textEditorPanel.Controls.Add(this.turnOnButton);
            this.textEditorPanel.Controls.Add(this.iPodScreen);
            this.textEditorPanel.Controls.Add(this.ipodPicture);
            this.textEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorPanel.Location = new System.Drawing.Point(0, 40);
            this.textEditorPanel.Name = "textEditorPanel";
            this.textEditorPanel.Size = new System.Drawing.Size(656, 619);
            this.textEditorPanel.TabIndex = 5;
            // 
            // turnOnButton
            // 
            this.turnOnButton.BackColor = System.Drawing.Color.Transparent;
            this.turnOnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.turnOnButton.FlatAppearance.BorderSize = 0;
            this.turnOnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.turnOnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.turnOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOnButton.Location = new System.Drawing.Point(501, -4);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(141, 21);
            this.turnOnButton.TabIndex = 7;
            this.turnOnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.turnOnButton_Click);
            // 
            // iPodScreen
            // 
            this.iPodScreen.BackColor = System.Drawing.Color.White;
            this.iPodScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iPodScreen.Controls.Add(this.textView);
            this.iPodScreen.Controls.Add(this.albumTitleTextBox);
            this.iPodScreen.Controls.Add(this.songTitleTextBox);
            this.iPodScreen.Controls.Add(this.artistNameTextBox);
            this.iPodScreen.Location = new System.Drawing.Point(81, 78);
            this.iPodScreen.Name = "iPodScreen";
            this.iPodScreen.Size = new System.Drawing.Size(480, 501);
            this.iPodScreen.TabIndex = 6;
            // 
            // ipodPicture
            // 
            this.ipodPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipodPicture.Image = global::iPodEmulator.Properties.Resources.ipod;
            this.ipodPicture.InitialImage = null;
            this.ipodPicture.Location = new System.Drawing.Point(0, 0);
            this.ipodPicture.Name = "ipodPicture";
            this.ipodPicture.Size = new System.Drawing.Size(656, 619);
            this.ipodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ipodPicture.TabIndex = 5;
            this.ipodPicture.TabStop = false;
            this.ipodPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ipodPicture_MouseClick);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 659);
            this.Controls.Add(this.textEditorPanel);
            this.Controls.Add(this.ipodEditorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.ipodEditorMenu;
            this.Name = "TextEditorForm";
            this.Text = "iPod Text Editor";
            this.ipodEditorMenu.ResumeLayout(false);
            this.ipodEditorMenu.PerformLayout();
            this.textEditorPanel.ResumeLayout(false);
            this.iPodScreen.ResumeLayout(false);
            this.iPodScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textView;
        private System.Windows.Forms.MenuStrip ipodEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.TextBox artistNameTextBox;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.Panel textEditorPanel;
        private System.Windows.Forms.PictureBox ipodPicture;
        private System.Windows.Forms.Panel iPodScreen;
        private System.Windows.Forms.Button turnOnButton;
    }
}

