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
    public partial class relogio : Form
    {
        public relogio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int h = 0; h <= 24; h++)
            {
                for (int m = 0; m <= 60; m++)
                {
                    for (int s = 0; s <= 60; s++ )
                    {
                        lblHora.Text = Convert.ToString (h);
                        lblMin.Text = Convert.ToString(m);
                        lblS.Text = Convert.ToString(s);
                        lblHora.Refresh();
                        lblMin.Refresh();
                        lblS.Refresh();

                    }
                }
            }
        }
    }
}
