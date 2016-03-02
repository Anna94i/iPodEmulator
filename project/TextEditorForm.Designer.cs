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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistNameTextBox = new System.Windows.Forms.TextBox();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.ipodEditorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textView
            // 
            this.textView.BackColor = System.Drawing.Color.Black;
            this.textView.ForeColor = System.Drawing.Color.White;
            this.textView.Location = new System.Drawing.Point(0, 199);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(480, 480);
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
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ipodEditorMenu.Location = new System.Drawing.Point(0, 0);
            this.ipodEditorMenu.Name = "ipodEditorMenu";
            this.ipodEditorMenu.Size = new System.Drawing.Size(479, 40);
            this.ipodEditorMenu.TabIndex = 1;
            this.ipodEditorMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // artistNameTextBox
            // 
            this.artistNameTextBox.BackColor = System.Drawing.Color.Black;
            this.artistNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.artistNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistNameTextBox.ForeColor = System.Drawing.Color.White;
            this.artistNameTextBox.Location = new System.Drawing.Point(0, 40);
            this.artistNameTextBox.Name = "artistNameTextBox";
            this.artistNameTextBox.Size = new System.Drawing.Size(479, 34);
            this.artistNameTextBox.TabIndex = 2;
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
            this.songTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.songTitleTextBox.Location = new System.Drawing.Point(0, 74);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(479, 49);
            this.songTitleTextBox.TabIndex = 3;
            this.songTitleTextBox.Text = "Title";
            this.songTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.songTitleTextBox.Click += new System.EventHandler(this.songTitleTextBox_Click);
            this.songTitleTextBox.Leave += new System.EventHandler(this.songTitleTextBox_Leave);
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.BackColor = System.Drawing.Color.Black;
            this.albumTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumTitleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.albumTitleTextBox.Location = new System.Drawing.Point(0, 123);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(479, 34);
            this.albumTitleTextBox.TabIndex = 4;
            this.albumTitleTextBox.Text = "One more text";
            this.albumTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.albumTitleTextBox.Click += new System.EventHandler(this.albumTitleTextBox_Click);
            this.albumTitleTextBox.Leave += new System.EventHandler(this.albumTitleTextBox_Leave);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 684);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.artistNameTextBox);
            this.Controls.Add(this.textView);
            this.Controls.Add(this.ipodEditorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.ipodEditorMenu;
            this.Name = "TextEditorForm";
            this.Text = "iPod Text Editor";
            this.ipodEditorMenu.ResumeLayout(false);
            this.ipodEditorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textView;
        private System.Windows.Forms.MenuStrip ipodEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox artistNameTextBox;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.TextBox albumTitleTextBox;
    }
}

