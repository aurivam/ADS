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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string Usuario;
            int Senha;
            // declaraçaõ de variaveis.

            Usuario= txtusuario.Text;
            Senha= Convert.ToInt32(txtsenha.Text);

            if( Usuario=="admin" & Senha == 123)
            {
                frmMenuPrincipal abrir= new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuario ou senha incorreto!");
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtsenha.Clear();
        }
    }
}
