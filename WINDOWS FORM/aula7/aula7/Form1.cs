using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula7
{
    public partial class Form1 : Form
    {
        double valorMemoria;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            valorMemoria = 0;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valorMemoria = valorMemoria + Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valorMemoria = valorMemoria - Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valorMemoria = valorMemoria * Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valorMemoria = valorMemoria / Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            valorMemoria = 0;
            txtResult.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(valorMemoria);
        }
    }
}
