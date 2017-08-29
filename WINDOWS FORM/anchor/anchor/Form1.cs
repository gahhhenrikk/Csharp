using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anchor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Text = "Top Most Off";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Text = "Top Most ON";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            button4.Visible = true;
            if (checkBox1.Checked)
            {
                textBox1.Text = "É funcionário";
            }
            else
            {
                textBox1.Text = "Não é funcionário";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Width = 461;
            button4.Visible = false;  //para nao ser visivel o botao, só alterar a propriedade visible para false
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
