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

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, n, fact=1;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            n = float.Parse(textBox3.Text);
            textBox4.Text=(a+b).ToString();
            textBox5.Text = (a - b).ToString();
            textBox6.Text = (a * b).ToString();
            textBox7.Text = (a / b).ToString();
            textBox8.Text = (Math.Pow(a,n)).ToString();
            for(int i=1; i<=a; i++)
            {
                fact = fact * i;
            }
            textBox9.Text = fact.ToString();
        }
    }
}
