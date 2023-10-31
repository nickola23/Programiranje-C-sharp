using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datoteke_Osoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBox1.Text;
                string prezime = textBox2.Text;
                int god = Convert.ToInt32(textBox3.Text);
                Osoba o = new Osoba(ime, prezime, god);
                StreamWriter sw = new StreamWriter("spisak.txt", true);
                o.pisi(sw);
                sw.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch(Exception err)
            {
                MessageBox.Show("Greska", err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba o, max;
                listBox1.Items.Clear();
                StreamReader sr = new StreamReader("spisak.txt");
                max = new Osoba();
                max.citaj(sr);
                listBox1.Items.Add(max.ToString());
                while (!sr.EndOfStream)
                {
                    o = new Osoba();
                    o.citaj(sr);
                    listBox1.Items.Add(o.ToString());
                }
                textBox4.Text = max.ToString();
                sr.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show("Greska", err.Message);
            }
        }
    }
}
