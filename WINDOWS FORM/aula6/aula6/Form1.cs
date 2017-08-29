using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mensagem de boas vindasz
            //MessageBox("Seja bem vindo");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtSoma.Text = Convert.ToString (Convert.ToDecimal(txtNota1.Text) + Convert.ToDecimal(txtNota2.Text) + Convert.ToDecimal(txtNota3.Text));
            txtMedia.Text = Convert.ToString(    (Convert.ToDecimal(txtNota1.Text) + 
                                                 Convert.ToDecimal(txtNota2.Text) + 
                                                 Convert.ToDecimal(txtNota3.Text) ) /3 );
            txtNota1.Text = ""; //deixar o campo vazio
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota1.Focus(); //cursor vai para campo nota 1 automaticamente
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkRed; //ao passar o mouse muda para vermelho a cor do label
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkRed;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkRed;
        }
    }
}
