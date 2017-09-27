using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pret1, pret2, pret3, pret4;
            int buc1, buc2, buc3, buc4;
            int adaos1, adaos2, adaos3, adaos4;
            int total;
            pret1 = int.Parse(textBox2.Text);
            pret2 = int.Parse(textBox8.Text);
            pret3 = int.Parse(textBox9.Text);
            pret4 = int.Parse(textBox10.Text);
            buc1 = int.Parse(numericUpDown1.Value.ToString());
            buc2 = int.Parse(numericUpDown2.Value.ToString());
            buc3 = int.Parse(numericUpDown3.Value.ToString());
            buc4 = int.Parse(numericUpDown4.Value.ToString());
            adaos1 = int.Parse(textBox4.Text) * pret1 / 100;
            adaos2 = int.Parse(textBox14.Text) * pret2 / 100;
            adaos3 = int.Parse(textBox15.Text) * pret3 / 100;
            adaos4 = int.Parse(textBox16.Text) * pret4 / 100;
            total = (pret1 + adaos1) * buc1 + (pret2 + adaos2) * buc2 + (pret3 + adaos3) * buc3 + (pret4 + adaos4) * buc4;
            textBox17.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
