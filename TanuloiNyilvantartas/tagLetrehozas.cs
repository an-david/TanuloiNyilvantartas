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
    public partial class tagLetrehozas : Form
    {
        public tagLetrehozas()
        {
            InitializeComponent();
        }

        private void tagLetrehozas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button_Felvetel_Click(object sender, EventArgs e)
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
            } else if (!(tanuloIrSzam > 0))
            {
                MessageBox.Show("Irányítószám megadása kötelező.", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_IrSzam.Focus();
                return;
            } else if (string.IsNullOrWhiteSpace(tanuloOrszag))
            {
                MessageBox.Show("Ország megadása kötelező.", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_Orszag.Focus();
                return;
            } else
            {
                Program.sql.CommandText = "INSERT INTO ugyfel (nev, szulev, irszam, orsz) VALUES ('" + tanuloNeve + "', " + tanuloSzulEv + ", " + tanuloIrSzam + ", '" + tanuloOrszag + "');";
                Program.sql.ExecuteNonQuery();

                MessageBox.Show("Sikeres felvétel", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_Nev.Clear();
                numericUpDown_SzulEv.Value = 2001;
                numericUpDown_IrSzam.Value = 0;
                comboBox_Orszag.Text = null;
            }
        }
    }
}
