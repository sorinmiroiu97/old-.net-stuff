using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2;
            double d;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
            }
            else if(d==0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
            }
            else
            {
                textBox6.Text = (-b / 2 * a).ToString();
                textBox8.Text = (Math.Sqrt(d) / 2 * a).ToString();
                textBox7.Text = (-b / 2 * a).ToString();
                textBox9.Text = (Math.Sqrt(d) / 2 * a).ToString();
            }

        }
    }
}
