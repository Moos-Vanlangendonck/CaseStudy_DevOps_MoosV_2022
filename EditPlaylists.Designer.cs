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
            this.SuspendLayout();
            // 
            // lsPlaylists
            // 
            this.lsPlaylists.FormattingEnabled = true;
            this.lsPlaylists.Location = new System.Drawing.Point(13, 13);
            this.lsPlaylists.Name = "lsPlaylists";
            this.lsPlaylists.Size = new System.Drawing.Size(182, 420);
            this.lsPlaylists.TabIndex = 0;
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
            this.btnRemoveList.Text = "remove list";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // btnRenamelist
            // 
            this.btnRenamelist.Location = new System.Drawing.Point(201, 71);
            this.btnRenamelist.Name = "btnRenamelist";
            this.btnRenamelist.Size = new System.Drawing.Size(75, 23);
            this.btnRenamelist.TabIndex = 3;
            this.btnRenamelist.Text = "rename list";
            this.btnRenamelist.UseVisualStyleBackColor = true;
            this.btnRenamelist.Click += new System.EventHandler(this.btnRenamelist_Click);
            // 
            // EditPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRenamelist);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.btwAddsong);
            this.Controls.Add(this.lsPlaylists);
            this.Name = "EditPlaylists";
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
    }
}