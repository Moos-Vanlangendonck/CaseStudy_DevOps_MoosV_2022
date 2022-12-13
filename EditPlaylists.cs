using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_DevOps_MoosV_2022
{
    public partial class EditPlaylists : Form
    {
        public EditPlaylists()
        {
            InitializeComponent();
        }

        private void EditPlaylists_Load(object sender, EventArgs e)
        {
            // Connect to database if exists
            SQLiteConnection _conn = new SQLiteConnection("Data Source=_database.db;Version=3;New=True,Compress=True;");
            ArrayList _list = new ArrayList();

            try
            {
                _conn.Open();
            }
            catch (Exception _err)
            {
                Console.WriteLine("Error: ");
                Console.Write(_err);
                Console.WriteLine("-------");
            }


            SQLiteCommand _cmd = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table'", _conn);
            using (SQLiteDataReader _reader = _cmd.ExecuteReader())
            {
                while(_reader.Read())
                {
                    _list.Add(_reader.GetString(0));
                }
            }
            foreach(var _playlist in _list)
            {
                lsPlaylists.Items.Add(_playlist.ToString());
            }
        }

        private void btwAddsong_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {

        }

        private void btnRenamelist_Click(object sender, EventArgs e)
        {

        }

        private void EditPlaylists_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing form doesn't mean application stopped running
            Application.Exit();
        }
    }
}
