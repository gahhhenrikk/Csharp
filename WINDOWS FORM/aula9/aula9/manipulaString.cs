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
    public partial class manipulaString : Form
    {
        public manipulaString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamanho = txtInicial.TextLength;
            string saida = "";

            for (int t = tamanho; t > 0; t--) {
                saida = saida + txtInicial.Text.Substring(t - 1, 1);
            }
            txtFinal.Text = saida;

            //======função de substituir palavra=======
            //saida = txtInicial.Text.Replace("%", "perc");
            //txtFinal.Text = saida;
        }
    }
}
