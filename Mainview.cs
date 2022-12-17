using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Policy;
using VideoLibrary;
using System.IO;
using MediaToolkit.Model;
using System.Security.Cryptography;
using MediaToolkit;
using System.Collections.Specialized;
using System.Data.SQLite;

namespace CaseStudy_DevOps_MoosV_2022
{
    public partial class Mainview : Form
    {

        private bool _canParse = false;
        public string _url;
        public string _location = "C:/Users/admin/Music/";

        public Mainview()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // nothing
        }

        private void _validateURL(string _url)
        {
            // validate input as a URL format
            // It is a valide URL when the request return value is 200
            // Afterwards validate that the url is in Youtube format for our purpose. (happens in external function)
            try
            {
                HttpWebRequest request = WebRequest.Create(_url) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    _canParse = true;
                }

            }
            catch (Exception _err)
            {
                Console.WriteLine("Error: ");
                Console.Write(_err);
                Console.WriteLine("_______");
            }
        }

        private void parseMP3(string _url)
        {
            // parse YoutubeURL into a .mp3 file format
            // store .mp3 in locally
            var _src = @_location;
            var _yt = YouTube.Default; // init youtube default
            var _vid = _yt.GetVideo(_url); // get youtube video from given url

            // store video file at the location of _src
            File.WriteAllBytes(_src + _vid.FullName, _vid.GetBytes());

            // create media file for input
            var _in = new MediaFile { Filename = _src + _vid.FullName };
            // create media file for output
            var _out = new MediaFile { Filename = $"{_src + (_vid.FullName).Remove(_vid.FullName.Length - 4)}.mp3" };

            // convert files with _in and _out
            using (var _engine = new Engine())
            {
                // retrieve file metadata (.mp4 atm)
                _engine.GetMetadata(_in);
                // actually convert the retrieved file extension into .mp3 using the metadata
                _engine.Convert(_in, _out);
            }

            File.Delete(_src + _vid.FullName);
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            // Check if input is Youtube URL format
            // Store parsed url to db
            _url = txtURL.Text;
            _validateURL(_url);
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string _txtName;
            using (CreatePlaylists _createPlaylists = new CreatePlaylists())
            {
                if (_createPlaylists.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _txtName = _createPlaylists.tbName;
                    // Connect to database if exists
                    SQLiteConnection _conn = new SQLiteConnection("Data Source=_database.db;Version=3;New=True,Compress=True;");

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

                    // Create a new table if not exists
                    // -----------------------------------

                    SQLiteCommand _cmd;
                    // create cmd string
                    string _createSQL = "DROP TABLE IF EXISTS " + _txtName + ";";
                    // create the cmd
                    _cmd = _conn.CreateCommand();
                    // load the string into cmd
                    _cmd.CommandText = _createSQL;
                    // execute the cmd
                    _cmd.ExecuteNonQuery();

                    // create the table with appropriate settings
                    _createSQL = "CREATE TABLE " + _txtName + " (id, name TEXT NOT NULL, audio BLOB NOT NULL);";
                    _cmd = _conn.CreateCommand();
                    _cmd.CommandText = _createSQL;
                    if (_cmd.ExecuteNonQuery() == -1)
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }

        private void Mainview_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Closing form doesn't mean application stopped running
            Application.Exit();
        }

        private void btnViewPlaylist_Click(object sender, EventArgs e)
        {
            EditPlaylists _editPlaylists = new EditPlaylists(); // Create view playlists view instance

            _editPlaylists.Show(); // Show the view playlist form
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (_canParse == true)
            {
                parseMP3(_url);
            }
        }
    }
}
