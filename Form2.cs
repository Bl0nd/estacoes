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
    public partial class frmPrimavera : Form
    {
        public frmPrimavera()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void radPrimavera01_CheckedChanged(object sender, EventArgs e)
        {
            pctPrimavera.Image = Properties.Resources.primavera01;
        }

        private void radPrimavera02_CheckedChanged(object sender, EventArgs e)
        {
            pctPrimavera.Image = Properties.Resources.primavera02;
        }

        private void radPrimavera03_CheckedChanged(object sender, EventArgs e)
        {
            pctPrimavera.Image = Properties.Resources.primavera03;
        }

        private void radPrimavera04_CheckedChanged(object sender, EventArgs e)
        {
            pctPrimavera.Image = Properties.Resources.primavera04;
        }
    }
}
