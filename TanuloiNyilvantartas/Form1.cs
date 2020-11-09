using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanuloiNyilvantartas
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void felvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.letrehoz.Show();
        }

        private void modósításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.modosit.Show();
        }
    }
}
