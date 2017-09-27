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

        private void button1_Click(object sender, EventArgs e)
        {
            int cas, cass, somaj, impozit, net;
            int brut = int.Parse(textBox1.Text);
            cas = int.Parse(textBox2.Text);
            cass = int.Parse(textBox3.Text);
            somaj = int.Parse(textBox4.Text);
            impozit = int.Parse(textBox5.Text);
            net = brut - (cas * brut/100 + cass * brut/100 + somaj * brut/100 + impozit * brut/100);
            textBox6.Text = net.ToString();
        }
    }
}
