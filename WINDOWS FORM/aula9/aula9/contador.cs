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
    public partial class contador : Form
    {
        public contador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6000; i++)
            {
                label1.Text = Convert.ToString(i);
                label1.Refresh();
            }
        }
    }
}
