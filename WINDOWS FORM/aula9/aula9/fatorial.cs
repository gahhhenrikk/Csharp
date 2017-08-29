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
    public partial class fatorial : Form
    {
        public fatorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int i = 1; i <= Convert.ToInt32(txtNumcalc.Text) ; i++)
            {
                fatorial *= i;
            }
            txtResult.Text = Convert.ToString(fatorial);
        }
    }
}
