using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int [] a = new int[100];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(i)
            {
                case 0: { textBox2.Text =vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
                case 1: { textBox3.Text = vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
                case 2: { textBox4.Text = vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
                case 3: { textBox5.Text = vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
                case 4: { textBox6.Text = vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
                case 5: { textBox7.Text = vScrollBar1.Value.ToString(); a[i] = vScrollBar1.Value; i++; break; }
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxim = 0;
            for(i=0; i<6; i++)
            {
                if (a[i] > a[i + 1]) maxim = a[i];
                else if (a[i] < a[i + 1]) maxim = a[i + 1];
            }
            textBox8.Text = maxim.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int minim = 0;
            for (i = 0; i < 6; i++)
            {
                if (a[i] < a[i + 1]) minim = a[i];
                else if (a[i] > a[i + 1]) minim = a[i + 1];
            }
            textBox9.Text = minim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int aux;
            for(i=0; i< 5; i++)
            {
                for(j=i+1;j<=5;j++)
                if(a[i]>a[j])
                {
                    aux = a[i];
                    a[i]=a[j];
                    a[j] = aux;
                }
            }
            textBox10.Text = a[0].ToString();
            textBox11.Text = a[1].ToString();
            textBox12.Text = a[2].ToString();
            textBox13.Text = a[3].ToString();
            textBox14.Text = a[4].ToString();
            textBox15.Text = a[5].ToString();
        }
        public int j=0;
        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show(a[j].ToString());
            j++;
        }
    }
}
