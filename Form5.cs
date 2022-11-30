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
    public partial class frmInverno : Form
    {
        public frmInverno()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void radInverno01_CheckedChanged(object sender, EventArgs e)
        {
            pctInverno.Image = Properties.Resources.inverno01;
        }

        private void radInverno02_CheckedChanged(object sender, EventArgs e)
        {
            pctInverno.Image = Properties.Resources.inverno02;
        }

        private void radInverno03_CheckedChanged(object sender, EventArgs e)
        {
            pctInverno.Image = Properties.Resources.inverno03;
        }

        private void radInverno04_CheckedChanged(object sender, EventArgs e)
        {
            pctInverno.Image = Properties.Resources.inverno04;
        }
    }
}
