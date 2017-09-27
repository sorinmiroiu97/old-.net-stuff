using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0, j = 0;
        int[,] a = new int[100, 100];
        int[,] b = new int[100, 100];
        int[,] c = new int[100, 100];
        private void button1_Click(object sender, EventArgs e)
        {
            textBox19.Text = (int.Parse(textBox1.Text) + int.Parse(textBox10.Text)).ToString();
            textBox20.Text = (int.Parse(textBox2.Text) + int.Parse(textBox11.Text)).ToString();
            textBox21.Text = (int.Parse(textBox3.Text) + int.Parse(textBox12.Text)).ToString();
            textBox22.Text = (int.Parse(textBox4.Text) + int.Parse(textBox13.Text)).ToString();
            textBox23.Text = (int.Parse(textBox5.Text) + int.Parse(textBox14.Text)).ToString();
            textBox24.Text = (int.Parse(textBox6.Text) + int.Parse(textBox15.Text)).ToString();
            textBox25.Text = (int.Parse(textBox7.Text) + int.Parse(textBox16.Text)).ToString();
            textBox26.Text = (int.Parse(textBox8.Text) + int.Parse(textBox17.Text)).ToString();
            textBox27.Text = (int.Parse(textBox9.Text) + int.Parse(textBox18.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MATRICEA A
            a[1, 1] = int.Parse(textBox1.Text.ToString());
            a[1, 2] = int.Parse(textBox2.Text.ToString());
            a[1, 3] = int.Parse(textBox3.Text.ToString());
            a[2, 1] = int.Parse(textBox4.Text.ToString());
            a[2, 2] = int.Parse(textBox5.Text.ToString());
            a[2, 3] = int.Parse(textBox6.Text.ToString());
            a[3, 1] = int.Parse(textBox7.Text.ToString());
            a[3, 2] = int.Parse(textBox8.Text.ToString());
            a[3, 3] = int.Parse(textBox9.Text.ToString());

            //MATRICEA B
            b[1, 1] = int.Parse(textBox10.Text.ToString());
            b[1, 2] = int.Parse(textBox11.Text.ToString());
            b[1, 3] = int.Parse(textBox12.Text.ToString());
            b[2, 1] = int.Parse(textBox13.Text.ToString());
            b[2, 2] = int.Parse(textBox14.Text.ToString());
            b[2, 3] = int.Parse(textBox15.Text.ToString());
            b[3, 1] = int.Parse(textBox16.Text.ToString());
            b[3, 2] = int.Parse(textBox17.Text.ToString());
            b[3, 3] = int.Parse(textBox18.Text.ToString());

            textBox19.Text = (a[1, 1] * b[1, 1] + a[1, 2] * b[2, 1] + a[1, 3] * b[3, 1]).ToString();
            textBox20.Text = (a[1, 1] * b[1, 2] + a[1, 2] * b[2, 2] + a[1, 3] * b[3, 2]).ToString();
            textBox21.Text = (a[1, 1] * b[1, 3] + a[1, 2] * b[2, 3] + a[1, 3] * b[3, 3]).ToString();
            textBox22.Text = (a[2, 1] * b[1, 1] + a[2, 2] * b[2, 1] + a[2, 3] * b[3, 1]).ToString();
            textBox23.Text = (a[2, 1] * b[1, 2] + a[2, 2] * b[2, 2] + a[2, 3] * b[3, 2]).ToString();
            textBox24.Text = (a[2, 1] * b[1, 3] + a[2, 2] * b[2, 3] + a[2, 3] * b[3, 3]).ToString();
            textBox25.Text = (a[3, 1] * b[1, 1] + a[3, 2] * b[2, 1] + a[3, 3] * b[3, 1]).ToString();
            textBox26.Text = (a[3, 1] * b[1, 2] + a[3, 2] * b[2, 2] + a[3, 3] * b[3, 2]).ToString();
            textBox27.Text = (a[3, 1] * b[1, 3] + a[3, 2] * b[2, 3] + a[3, 3] * b[3, 3]).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox19.Text = textBox1.Text.ToString();
            textBox20.Text = textBox4.Text.ToString();
            textBox21.Text = textBox7.Text.ToString();
            textBox22.Text = textBox2.Text.ToString();
            textBox23.Text = textBox5.Text.ToString();
            textBox24.Text = textBox8.Text.ToString();
            textBox25.Text = textBox3.Text.ToString();
            textBox26.Text = textBox6.Text.ToString();
            textBox27.Text = textBox9.Text.ToString();
        }

        //METHOD MATRIXPOWER
        public void matrixpower(int[,] a, int n)
        {
            for (i = 1; i <= 3; i++)
                for (j = 1; j <= 3; j++)
                    b[i, j] = a[i, j];
            while (n > 0)
            {
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                        c[i, j] = 0;
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                        for (int k = 1; k <= 3; k++)
                            c[i, j] += a[i, k] * b[k, j];
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                        a[i, j] = c[i, j];
                n--;
            }
            
            textBox19.Text = a[1, 1].ToString();
            textBox20.Text = a[1, 2].ToString();
            textBox21.Text = a[1, 3].ToString();
            textBox22.Text = a[2, 1].ToString();
            textBox23.Text = a[2, 2].ToString();
            textBox24.Text = a[2, 3].ToString();
            textBox25.Text = a[3, 1].ToString();
            textBox26.Text = a[3, 2].ToString();
            textBox27.Text = a[3, 3].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MATRICEA A
            a[1, 1] = int.Parse(textBox1.Text.ToString());
            a[1, 2] = int.Parse(textBox2.Text.ToString());
            a[1, 3] = int.Parse(textBox3.Text.ToString());
            a[2, 1] = int.Parse(textBox4.Text.ToString());
            a[2, 2] = int.Parse(textBox5.Text.ToString());
            a[2, 3] = int.Parse(textBox6.Text.ToString());
            a[3, 1] = int.Parse(textBox7.Text.ToString());
            a[3, 2] = int.Parse(textBox8.Text.ToString());
            a[3, 3] = int.Parse(textBox9.Text.ToString());

            int n = int.Parse(textBox28.Text.ToString());
            n--;
            matrixpower(a, n);
        }


    private void button4_Click(object sender, EventArgs e)
        {
            textBox19.Text = textBox10.Text.ToString();
            textBox20.Text = textBox13.Text.ToString();
            textBox21.Text = textBox16.Text.ToString();
            textBox22.Text = textBox11.Text.ToString();
            textBox23.Text = textBox14.Text.ToString();
            textBox24.Text = textBox17.Text.ToString();
            textBox25.Text = textBox12.Text.ToString();
            textBox26.Text = textBox15.Text.ToString();
            textBox27.Text = textBox18.Text.ToString();
        }
    }
}
