using Dapper;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace CaseStudy_DevOps_MoosV_2022
{
    public partial class EditPlaylists : Form
    {
        public EditPlaylists()
        {
            InitializeComponent();
        }
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(@"Data Source=_database.db;Version=3;New=True,Compress=True;");
        }
        private void LoadPlaylist()
        {
            using (IDbConnection _db = GetConnection())
            {
                var _list = _db.Query("SELECT name FROM sqlite_master WHERE type='table'").ToList();
                foreach (var u in _list)
                {
                    lsPlaylists.Items.Add((u.name).ToString());
                }

                if (lsPlaylists.Items.Count > 1)
                    lsPlaylists.SelectedIndex = 1;
                else
                    lsPlaylists.SelectedIndex = 0;
                lsPlaylists.Refresh();
            }
        }

        private void EditPlaylists_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
            lsSongs.Items.Clear();

            using (IDbConnection _db = GetConnection())
            {
                var _list = _db.Query("SELECT name FROM " + lsPlaylists.SelectedItem.ToString()).ToList();
                foreach (var _song in _list)
                {
                    lsSongs.Items.Add(_song.name.ToString());
                }
            }
        }

        private void btwAddsong_Click(object sender, EventArgs e)
        {
            string _listToAdd = lsPlaylists.SelectedItem.ToString();

            ofdAddSong.ShowDialog();
            //var _file = File.ReadAllBytes(Path.GetFullPath(ofdAddSong.FileName));
            //var _file = File.OpenRead(Path.GetFullPath(ofdAddSong.FileName));
            var _file = new MediaFile(Path.GetFullPath(ofdAddSong.FileName));

            using (IDbConnection _db = GetConnection())
            {
                var cmd = "INSERT INTO '" + _listToAdd + "' (name, audio) VALUES ('" + System.IO.Path.GetFileNameWithoutExtension(ofdAddSong.FileName).ToString() + "', @file)";
                var Params = new DynamicParameters();
                Params.Add("@file", DbType.Binary);
                _db.Execute(cmd, Params);
            }
            lsSongs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(ofdAddSong.FileName));
            _file = null;
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            string _listToRem = lsPlaylists.SelectedItem.ToString();
            var item = lsPlaylists.Items.IndexOf(_listToRem);

            using (IDbConnection _db = GetConnection())
            {
                _db.Execute("DROP TABLE '" + _listToRem + "'");

                lsPlaylists.Items.RemoveAt(lsPlaylists.SelectedIndex);
                lsPlaylists.Update();
                lsPlaylists.Refresh();
                lsPlaylists.SetSelected(0, true);
            }
            lsSongs.Items.Clear();

            using (IDbConnection _db = GetConnection())
            {
                if (lsPlaylists.SelectedItem.ToString() != "")
                {
                    var _list = _db.Query("SELECT name FROM " + lsPlaylists.SelectedItem.ToString()).ToList();
                    foreach (var _song in _list)
                    {
                        lsSongs.Items.Add((_song.name).ToString());
                    }
                }
            }
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

                    using (IDbConnection _db = GetConnection())
                    {
                        _db.Execute("ALTER TABLE '" + _listToRen + "' RENAME TO '" + _txtRename + "'");

                        var item = lsPlaylists.Items.IndexOf(_listToRen);
                        lsPlaylists.Items.RemoveAt(item);
                        lsPlaylists.Items.Insert(item, _txtRename);
                        lsPlaylists.SelectedIndex = item;
                        lsPlaylists.Refresh();
                    }
                }
            }

            lsSongs.Items.Clear();

            using (IDbConnection _db = GetConnection())
            {
                if (lsPlaylists.SelectedItem.ToString() != "")
                {
                    var _list = _db.Query("SELECT name FROM " + lsPlaylists.SelectedItem.ToString()).ToList();
                    foreach (var _song in _list)
                    {
                        lsSongs.Items.Add((_song.name).ToString());
                    }
                }
            }
        }

        private void EditPlaylists_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing form doesn't mean application stopped running
            //Application.Exit();
        }

        private void lsPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsSongs.Items.Count >= 1)
                lsSongs.Items.Clear();

            using (IDbConnection _db = GetConnection())
            {
                if (lsPlaylists.SelectedItem == null)
                {
                    lsPlaylists.SetSelected(0, true);
                    var item = lsPlaylists.SelectedItem.ToString();
                    int index = lsPlaylists.FindString(item);
                    if (index != -1)
                        lsPlaylists.SetSelected(index, true);
                }
                if (lsPlaylists.Items.Contains(lsPlaylists.SelectedIndex) || lsPlaylists.Items.Contains(lsPlaylists.SelectedItem))
                {
                    var _list = _db.Query("SELECT name FROM " + lsPlaylists.SelectedItem.ToString()).ToList();
                    foreach (var _song in _list)
                    {
                        lsSongs.Items.Add(_song.name.ToString());
                    }
                }
            }
        }
    }
}
