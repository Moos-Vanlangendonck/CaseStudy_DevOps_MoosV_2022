namespace CaseStudy_DevOps_MoosV_2022
{
    partial class ViewPlaylists
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
            this.SuspendLayout();
            // 
            // ViewPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ViewPlaylists";
            this.ShowIcon = false;
            this.Text = "View playlists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewPlaylists_FormClosing);
            this.Load += new System.EventHandler(this.ViewPlaylists_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}