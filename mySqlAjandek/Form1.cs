using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySqlAjandek
{
    public partial class FormAjandek : Form
    {
        MySqlConnection conn;
        public FormAjandek()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=root;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
            AdatBetoltes();
        }
        void AdatBetoltes()
        {
            string sql = @"
                        SELECT id, nev, uzlet
                        FROM ajandek
                        ORDER BY nev
                        ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                lstBx_ajandek.Items.Clear();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");

                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    lstBx_ajandek.Items.Add(ajandek);
                }
            }
        }

        private void bttn_felvesz_Click(object sender, EventArgs e)
        {
            if (bttn_felvesz.Text == "Felvesz")
            {
                if (txtBx_nev.Text != "")
                {
                    var insertComm = conn.CreateCommand();

                    insertComm.CommandText = @"
                    INSERT INTO ajandek (nev, uzlet)
                    VALUES (@nev,@uzlet)";

                    insertComm.Parameters.AddWithValue("@nev", txtBx_nev.Text);
                    insertComm.Parameters.AddWithValue("@uzlet", txtBx_uzlet.Text == "" ? "Saját készítésű" : txtBx_uzlet.Text);

                    var muvelet = insertComm.ExecuteNonQuery();
                    if (muvelet >= 1)
                        MessageBox.Show("Sikeres adatfelvétel", "Siker!");
                    else
                        MessageBox.Show("Nem sikerült az adatot beszúrni!", "Hiba!");

                    txtBx_nev.Text = "";
                    txtBx_uzlet.Text = "";
                    AdatBetoltes();
                }
                else MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
            }
        }

        private void lstBx_ajandek_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstBx_ajandek.SelectedItem != null)
            {
                var result = MessageBox.Show("Biztos törli a kijelölt elemet?", "Törlés", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var insertComm = conn.CreateCommand();

                    insertComm.CommandText = @"
                    DELETE FROM ajandek 
                    WHERE id=@szam";

                    var szam = (Ajandek)lstBx_ajandek.SelectedItem;
                    insertComm.Parameters.AddWithValue("@szam", szam.Id);

                    var muvelet = insertComm.ExecuteNonQuery();
                    if (muvelet >= 1)
                    {
                        MessageBox.Show("Sikeres törlés", "Siker!");
                        lstBx_ajandek.Items.Remove(lstBx_ajandek.SelectedItem);
                    }
                    else MessageBox.Show("Nem sikerült az adatot törölni!", "Hiba!");                 
                }

            }
        }
    }
}
