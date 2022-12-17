using MediaToolkit.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void LoadPlaylist()
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
                while (_reader.Read())
                {
                    _list.Add(_reader.GetString(0));
                }
            }
            foreach (var _playlist in _list)
            {
                lsPlaylists.Items.Add(_playlist.ToString());
            }
            _conn.Close();
            lsPlaylists.SelectedIndex = 1;
            lsPlaylists.Refresh();
        }

        private void EditPlaylists_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
            ArrayList _list = new ArrayList();

            lsSongs.Items.Clear();
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

            SQLiteCommand _cmd = new SQLiteCommand("SELECT name FROM " + lsPlaylists.SelectedItem.ToString(), _conn);
            using (SQLiteDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _list.Add(_reader.GetString(0));
                }
            }
            foreach (var _song in _list)
            {
                lsSongs.Items.Add(_song.ToString());
            }

            _conn.Close();
        }

        private void btwAddsong_Click(object sender, EventArgs e)
        {
            string _listToAdd = lsPlaylists.SelectedItem.ToString();

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

            ofdAddSong.ShowDialog();
            byte[] _file = File.ReadAllBytes(Path.GetFullPath(ofdAddSong.FileName));

            SQLiteCommand _cmd = new SQLiteCommand("INSERT INTO '" + _listToAdd + "' (name, audio) VALUES ('" + System.IO.Path.GetFileNameWithoutExtension(ofdAddSong.FileName).ToString() + "', @file)", _conn);
            //_cmd.Parameters.AddWithValue("@file", _file);
            //_cmd.Parameters.Add("@file", DbType.Binary, _file.Length).Value = _file;
            //_cmd.Parameters.Add("@file", DbType.Binary, _file.Length);
            _cmd.Parameters.AddWithValue("@file", _file).DbType = DbType.Binary;

            _cmd.ExecuteNonQuery();
            lsSongs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(ofdAddSong.FileName));
            _conn.Close();
            _file = null;
            _cmd.Dispose();
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            string _listToRem = lsPlaylists.SelectedItem.ToString();

            // Connect to database if exists
            SQLiteConnection _conn = new SQLiteConnection("Data Source=_database.db;Version=3;New=True,Compress=True;");
            SQLiteCommand _cmd = new SQLiteCommand("DROP TABLE '" + _listToRem + "'", _conn);

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

            _cmd.ExecuteNonQuery();
            _conn.Close();
            lsPlaylists.Items.RemoveAt(lsPlaylists.SelectedIndex);
            lsPlaylists.SelectedIndex = 1;
            lsPlaylists.Refresh();
        }

        private void btnRenamelist_Click(object sender, EventArgs e)
        {
            string _listToRen = lsPlaylists.SelectedItem.ToString();
            string _txtRename;
            
            using (CustomMessageBox msb = new CustomMessageBox())
            {
                if (msb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _txtRename = msb.newName;

                    // Connect to database if exists
                    SQLiteConnection _conn = new SQLiteConnection("Data Source=_database.db;Version=3;New=True,Compress=True;");
                    SQLiteCommand _cmd = new SQLiteCommand("ALTER TABLE '" + _listToRen + "' RENAME TO '" + _txtRename + "'", _conn);

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

                    _cmd.ExecuteNonQuery();
                    _conn.Close();

                    var item = lsPlaylists.Items.IndexOf(_listToRen);
                    lsPlaylists.Items.RemoveAt(item);
                    lsPlaylists.Items.Insert(item, _txtRename);
                    lsPlaylists.Refresh();
                }
            }
            
        }

        private void EditPlaylists_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing form doesn't mean application stopped running
            Application.Exit();
        }

        private void lsPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList _list = new ArrayList();

            lsSongs.Items.Clear();
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

            SQLiteCommand _cmd = new SQLiteCommand("SELECT name FROM " + lsPlaylists.SelectedItem.ToString(), _conn);
            using (SQLiteDataReader _reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    _list.Add(_reader.GetString(0));
                }
            }
            foreach (var _song in _list)
            {
                lsSongs.Items.Add(_song.ToString());
            }

            _conn.Close();
        }
    }
}
