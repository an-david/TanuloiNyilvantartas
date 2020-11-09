using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TanuloiNyilvantartas
{
    public partial class tagModositas : Form
    {
        public tagModositas()
        {
            InitializeComponent();
        }

        private void tagModositas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private static int tanuloAzon = 0;

        private void tagModositas_Load(object sender, EventArgs e)
        {
            dataGridView_Tanulok.ColumnCount = 5;
            dataGridView_Tanulok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Tanulok.Columns[1].Name = "nev";
            dataGridView_Tanulok.Columns[1].HeaderText = "Tanuló Neve";

            dataGridView_Tanulok.Columns[0].Name = "azon";
            dataGridView_Tanulok.Columns[2].Name = "szulev";
            dataGridView_Tanulok.Columns[3].Name = "irszam";
            dataGridView_Tanulok.Columns[4].Name = "orszag";

            tablazatFeltoltese();
        }

        private void tablazatFeltoltese()
        {
            try
            {
                Program.sql.CommandText = "SELECT azon, nev, szulev, irszam, orsz FROM ugyfel";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_Tanulok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_Tanulok.Rows[uj_sor_indexe];

                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["szulev"].Value = dr.GetInt32("szulev");
                        uj_sor.Cells["irszam"].Value = dr.GetInt32("irszam");
                        uj_sor.Cells["orszag"].Value = dr.GetString("orsz");

                        dataGridView_Tanulok.Columns["azon"].Visible = false;
                        dataGridView_Tanulok.Columns["szulev"].Visible = false;
                        dataGridView_Tanulok.Columns["irszam"].Visible = false;
                        dataGridView_Tanulok.Columns["orszag"].Visible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                throw;
            }
        }

        private void dataGridView_Tanulok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow uj_sor = dataGridView_Tanulok.Rows[e.RowIndex];

            tanuloAzon = (int) uj_sor.Cells["azon"].Value;
            textBox_Nev.Text = uj_sor.Cells["nev"].Value.ToString();
            numericUpDown_SzulEv.Value = (int) uj_sor.Cells["szulev"].Value;
            numericUpDown_IrSzam.Value = (int) uj_sor.Cells["irszam"].Value;
            comboBox_Orszag.Text = uj_sor.Cells["orszag"].Value.ToString();
        }

        private void button_Modosit_Click(object sender, EventArgs e)
        {
            string tanuloNeve = textBox_Nev.Text;
            decimal tanuloSzulEv = numericUpDown_SzulEv.Value;
            decimal tanuloIrSzam = numericUpDown_IrSzam.Value;
            string tanuloOrszag = comboBox_Orszag.Text;

            if (string.IsNullOrWhiteSpace(tanuloNeve))
            {
                MessageBox.Show("Név megadása kötelező.", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nev.Focus();
                return;
            }
            else if (!(tanuloIrSzam > 0))
            {
                MessageBox.Show("Irányítószám megadása kötelező.", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_IrSzam.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tanuloOrszag))
            {
                MessageBox.Show("Ország megadása kötelező.", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_Orszag.Focus();
                return;
            }
            else
            {
                Program.sql.CommandText = "UPDATE ugyfel SET nev = '" + tanuloNeve + "', szulev = " + tanuloSzulEv + ", irszam = " + tanuloIrSzam + ", orsz = '" + tanuloOrszag + "' WHERE azon = " + tanuloAzon + ";";
                Program.sql.ExecuteNonQuery();

                MessageBox.Show("Sikeres modósítás", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView_Tanulok.Rows.Clear();
                tablazatFeltoltese();
            }
        }
    }
}
