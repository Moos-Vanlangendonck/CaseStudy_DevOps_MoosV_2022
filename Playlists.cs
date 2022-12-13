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
    public partial class Playlists : Form
    {
        public Playlists()
        {
            InitializeComponent();
        }

        private void Playlists_Load(object sender, EventArgs e)
        {
        }

        static SQLiteConnection ConnectDB()
        {
            // Connect to database if exists
            SQLiteConnection _conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True,Compress=True;");

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
            return _conn;
        }

        static void CreateTB(SQLiteConnection _conn, string _tbName)
        {
            // Create a new table if not exists
            // -----------------------------------

            SQLiteCommand _cmd;

            // create cmd string
            string _createSQL = "DROP TABLE IF EXISTS " + _tbName + ";";
            // create the cmd
            _cmd = _conn.CreateCommand();
            // load the string into cmd
            _cmd.CommandText = _createSQL;
            // execute the cmd
            _cmd.ExecuteNonQuery();

            // create the table with appropriate settings
            _createSQL = "CREATE TABLE " + _tbName + " (id, name TEXT NOT NULL, audio BLOB NOT NULL);";
            _cmd = _conn.CreateCommand();
            _cmd.CommandText = _createSQL;
            _cmd.ExecuteNonQuery();
        }

        private void Playlists_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mainview mainview = new Mainview();
            mainview.Show(); // show mainview
            this.Hide();
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string _tbName = txtPlaylistName.Text;

            // initialize connection
            SQLiteConnection _conn;
            // connect to database
            _conn = ConnectDB();

            CreateTB(_conn, _tbName);
        }
    }
}
