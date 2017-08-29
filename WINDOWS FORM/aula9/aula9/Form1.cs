using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("O valor é: " +i);
            }
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            Form fat = new fatorial();
            fat.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form inv = new manipulaString();
            inv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cont = new contador();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form rel = new relogio();
            rel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form wd = new @while();
            wd.Show();
        }
    }
}
