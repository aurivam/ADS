using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADS
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        public void DesabilitarCampos()
        {
            txtnome.Enabled = false;
            txtidade.Enabled = false;
            txtcodigo.Enabled = false;
        }

        public void HabilitarCampos()
        {
            txtnome.Enabled = true;
            txtidade.Enabled = true;
            txtcodigo.Enabled = true;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.ResetText();
            txtidade.ResetText();
            txtcodigo.ResetText();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir= new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
