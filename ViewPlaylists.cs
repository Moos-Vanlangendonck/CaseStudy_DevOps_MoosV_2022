using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_DevOps_MoosV_2022
{
    public partial class ViewPlaylists : Form
    {
        public ViewPlaylists()
        {
            InitializeComponent();
        }

        private void ViewPlaylists_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mainview mainview = new Mainview();
            mainview.Show(); // show mainview
            this.Hide();
        }

        private void ViewPlaylists_Load(object sender, EventArgs e)
        {

        }

        static SQLiteConnection ConnectDB()
        {
            // Connect to database if exists
            SQLiteConnection _conn;
            _conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True,Compress=True;");

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

        static void CreateTB(SQLiteConnection _conn)
        {
            // Create a new table if not exists
            // SQLiteCommand _cmd;
            //string _createSQL = "Create TABLE songs (Col1 VARCHAR(20), Col2 INT)";
            //_cmd = _conn.CreateCommand();
            //_cmd.CommandText = _createSQL;
            //_cmd.ExecuteNonQuery();
        }

        static void FillTB(SQLiteConnection _conn)
        {
            // Fill table with the song's name, .mp3 file and id
            //SQLiteCommand _cmd;
            //_cmd = _conn.CreateCommand();
            //_cmd.CommandText = "INSERT INTO songs ()";
        }
    }
}
