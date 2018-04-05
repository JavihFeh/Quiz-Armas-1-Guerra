using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PronNot.DeskView
{
    public partial class Form2 : Form
    {
        private int pro;

        public Form2()
        {
            InitializeComponent();
            pro = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pro == 0)
            {
                progressBar1.Value = 20;

            }
            else if (pro == 20)
            {
                progressBar1.Value = 40;

            }
            else if (pro == 40)
            {
                progressBar1.Value = 60;

            }
            else if (pro == 60)
            {
                progressBar1.Value = 80;

            }
            else if (pro == 80)
            {
                progressBar1.Value = 100;

            }
            else if (pro == 100)
            {
                this.Close();
            }
        }
    }
}
