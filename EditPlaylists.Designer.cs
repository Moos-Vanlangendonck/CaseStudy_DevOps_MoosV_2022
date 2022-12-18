namespace CaseStudy_DevOps_MoosV_2022
{
    partial class EditPlaylists
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
            this.lsPlaylists = new System.Windows.Forms.ListBox();
            this.btwAddsong = new System.Windows.Forms.Button();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.btnRenamelist = new System.Windows.Forms.Button();
            this.ofdAddSong = new System.Windows.Forms.OpenFileDialog();
            this.lsSongs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsPlaylists
            // 
            this.lsPlaylists.FormattingEnabled = true;
            this.lsPlaylists.Location = new System.Drawing.Point(13, 13);
            this.lsPlaylists.Name = "lsPlaylists";
            this.lsPlaylists.Size = new System.Drawing.Size(182, 420);
            this.lsPlaylists.TabIndex = 0;
            this.lsPlaylists.SelectedIndexChanged += new System.EventHandler(this.lsPlaylists_SelectedIndexChanged);
            // 
            // btwAddsong
            // 
            this.btwAddsong.Location = new System.Drawing.Point(201, 13);
            this.btwAddsong.Name = "btwAddsong";
            this.btwAddsong.Size = new System.Drawing.Size(75, 23);
            this.btwAddsong.TabIndex = 1;
            this.btwAddsong.Text = "Add song";
            this.btwAddsong.UseVisualStyleBackColor = true;
            this.btwAddsong.Click += new System.EventHandler(this.btwAddsong_Click);
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(201, 42);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveList.TabIndex = 2;
            this.btnRemoveList.Text = "Remove list";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // btnRenamelist
            // 
            this.btnRenamelist.Location = new System.Drawing.Point(201, 71);
            this.btnRenamelist.Name = "btnRenamelist";
            this.btnRenamelist.Size = new System.Drawing.Size(75, 23);
            this.btnRenamelist.TabIndex = 3;
            this.btnRenamelist.Text = "Rename list";
            this.btnRenamelist.UseVisualStyleBackColor = true;
            this.btnRenamelist.Click += new System.EventHandler(this.btnRenamelist_Click);
            // 
            // lsSongs
            // 
            this.lsSongs.FormattingEnabled = true;
            this.lsSongs.Location = new System.Drawing.Point(201, 104);
            this.lsSongs.Name = "lsSongs";
            this.lsSongs.Size = new System.Drawing.Size(200, 329);
            this.lsSongs.TabIndex = 4;
            // 
            // EditPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsSongs);
            this.Controls.Add(this.btnRenamelist);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.btwAddsong);
            this.Controls.Add(this.lsPlaylists);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPlaylists";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPlaylists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPlaylists_FormClosing);
            this.Load += new System.EventHandler(this.EditPlaylists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsPlaylists;
        private System.Windows.Forms.Button btwAddsong;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Button btnRenamelist;
        private System.Windows.Forms.OpenFileDialog ofdAddSong;
        private System.Windows.Forms.ListBox lsSongs;
    }
}