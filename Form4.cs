using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacoes
{
    public partial class frmOutono : Form
    {
        public frmOutono()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void radOutono01_CheckedChanged(object sender, EventArgs e)
        {
            pctOutono.Image = Properties.Resources.outono01;
        }

        private void radOutono02_CheckedChanged(object sender, EventArgs e)
        {
            pctOutono.Image = Properties.Resources.outono02;
        }

        private void radOutono03_CheckedChanged(object sender, EventArgs e)
        {
            pctOutono.Image = Properties.Resources.outono03;
        }

        private void radOutono04_CheckedChanged(object sender, EventArgs e)
        {
            pctOutono.Image = Properties.Resources.outono04;
        }
    }
}
