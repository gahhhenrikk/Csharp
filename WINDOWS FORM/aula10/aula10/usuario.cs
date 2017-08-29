using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "adm" && txtSenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo ao sistema");

                Form frm1 = new Form1();
                frm1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados incorretos, digite novamente");
            }

            

        }
    }
}
