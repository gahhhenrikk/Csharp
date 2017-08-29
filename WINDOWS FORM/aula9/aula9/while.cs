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
    public partial class @while : Form
    {
        public @while()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < 5000)
            {
                i++;
                label1.Text = Convert.ToString(i);
                label1.Refresh();
            }

            //===========ESTRUTURA DO===========
            
            //do
            //{
            //i++;
            //label1.Text = Convert.ToString(i);
            //label1.Refresh();
            //} while (i <= 5000);
        }
    }
}
