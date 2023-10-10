using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericke_klase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // int
        private void button2_Click(object sender, EventArgs e)
        {
            Generici<int> a = new Generici<int>(Convert.ToInt32(textBox1.Text));
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generici<string> a = new Generici<string>(Convert.ToString(textBox1.Text));
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Generici<double> a = new Generici<double>(Convert.ToDouble(textBox1.Text));
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }
    }
}
