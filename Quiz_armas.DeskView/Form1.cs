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
    public partial class PronNot : Form
    {

        string sexo;

        public PronNot()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
         

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Seu nome é {0} {1}, sua idade é {2}, seu sexo é {3}.", nome.Text, sobrenome.Text, idade.Text, sexo));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void Form2(object sender, EventArgs e)
        {
            //timer1.Enable = true;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
            //timer1.Enable = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 10;
            if (this.Opacity == 100)
            {
                //timer1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checksim.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checknao.Checked = false;
        }

        private void PronNot_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "masculino";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "feminino";

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "indefinido";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void configuarçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void objetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre Abasobre = new sobre();
            Abasobre.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
