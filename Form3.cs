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
    public partial class frmVerao : Form
    {
        public frmVerao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void radVerao01_CheckedChanged(object sender, EventArgs e)
        {
            pctVerao.Image = Properties.Resources.verao01;
        }

        private void radVerao02_CheckedChanged(object sender, EventArgs e)
        {
            pctVerao.Image = Properties.Resources.verao02;
        }

        private void radVerao03_CheckedChanged(object sender, EventArgs e)
        {
            pctVerao.Image = Properties.Resources.verao03;
        }

        private void radVerao04_CheckedChanged(object sender, EventArgs e)
        {
            pctVerao.Image = Properties.Resources.verao04;
        }
    }
}
