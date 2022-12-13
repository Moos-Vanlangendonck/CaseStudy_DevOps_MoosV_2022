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
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(140, 220);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(473, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "URL here...";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(140, 260);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(145, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.Location = new System.Drawing.Point(468, 260);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(145, 23);
            this.btnEditPlaylist.TabIndex = 5;
            this.btnEditPlaylist.Text = "Edit playlist";
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            this.btnEditPlaylist.Click += new System.EventHandler(this.btnViewPlaylist_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(305, 260);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(145, 23);
            this.btnCreatePlaylist.TabIndex = 6;
            this.btnCreatePlaylist.Text = "Create playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "What song would you like to convert?";
            // 
            // Mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.btnEditPlaylist);
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
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Label label1;
    }
}

