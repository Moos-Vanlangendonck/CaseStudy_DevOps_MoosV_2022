using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CaseStudy_DevOps_MoosV_2022
{
    public partial class CreatePlaylists : Form
    {
        public string tbName { get; set; }
        public CreatePlaylists()
        {
            InitializeComponent();
        }

        private void Playlists_Load(object sender, EventArgs e)
        {
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text != "")
            {
                tbName = txtPlaylistName.Text;
            }
        }
    }
}
