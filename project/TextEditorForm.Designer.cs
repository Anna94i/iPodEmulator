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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.songTitleLabel = new System.Windows.Forms.Label();
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
            this.textView.TextChanged += new System.EventHandler(this.textView_TextChanged);
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
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
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
            // artistNameLabel
            // 
            this.artistNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.artistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistNameLabel.ForeColor = System.Drawing.Color.White;
            this.artistNameLabel.Location = new System.Drawing.Point(0, 40);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(479, 58);
            this.artistNameLabel.TabIndex = 2;
            this.artistNameLabel.Text = "Lose yourself";
            this.artistNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumTitleLabel.ForeColor = System.Drawing.Color.White;
            this.albumTitleLabel.Location = new System.Drawing.Point(0, 98);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(479, 45);
            this.albumTitleLabel.TabIndex = 3;
            this.albumTitleLabel.Text = "Eminem";
            this.albumTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.songTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songTitleLabel.ForeColor = System.Drawing.Color.White;
            this.songTitleLabel.Location = new System.Drawing.Point(0, 143);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(479, 53);
            this.songTitleLabel.TabIndex = 4;
            this.songTitleLabel.Text = "Relapse";
            this.songTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 684);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.artistNameLabel);
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Label songTitleLabel;
    }
}

