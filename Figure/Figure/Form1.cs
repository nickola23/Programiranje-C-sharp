using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float duzina = Convert.ToSingle(textBox1.Text);
            float sirina = Convert.ToSingle(textBox2.Text);
            Pravougaonik p = new Pravougaonik(10, 15, duzina, sirina);
            label6.Text = p.povrsina().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float duzina = Convert.ToSingle(textBox1.Text);
            float sirina = Convert.ToSingle(textBox2.Text);
            float visina = Convert.ToSingle(textBox3.Text);
            Kvadar k = new Kvadar(10, 15, 20, duzina, sirina, visina);
            label7.Text = k.povrsina().ToString();
            label9.Text = k.zapremina().ToString();
        }
    }
}
