namespace CaseStudy_DevOps_MoosV_2022
{
    partial class Mainview
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnViewPlaylist = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(100, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "URL here...";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(140, 10);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(145, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnViewPlaylist
            // 
            this.btnViewPlaylist.Location = new System.Drawing.Point(172, 114);
            this.btnViewPlaylist.Name = "btnViewPlaylist";
            this.btnViewPlaylist.Size = new System.Drawing.Size(145, 23);
            this.btnViewPlaylist.TabIndex = 5;
            this.btnViewPlaylist.Text = "View playlists";
            this.btnViewPlaylist.UseVisualStyleBackColor = true;
            this.btnViewPlaylist.Click += new System.EventHandler(this.btnViewPlaylist_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(12, 114);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(145, 23);
            this.btnCreatePlaylist.TabIndex = 6;
            this.btnCreatePlaylist.Text = "Create playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // Mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.btnViewPlaylist);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtURL);
            this.Name = "Mainview";
            this.ShowIcon = false;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainview_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnViewPlaylist;
        private System.Windows.Forms.Button btnCreatePlaylist;
    }
}

