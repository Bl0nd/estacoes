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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            new frmPrimavera().Show(); //Executar outro form
            Hide();//Esconder formúlario atual
        } 
        private void btnVerao_Click(object sender, EventArgs e)
        {
            new frmVerao().Show(); //Executar outro form
            Hide();//Esconder formúlario atual
        }

        private void btnOutono_Click(object sender, EventArgs e)
        {
            new frmOutono().Show(); //Executar outro form
            Hide();//Esconder formúlario atual
        }

        private void btnInverno_Click(object sender, EventArgs e)
        {
            new frmInverno().Show(); //Executar outro form
            Hide();//Esconder formúlario atual
        }
    }
}
