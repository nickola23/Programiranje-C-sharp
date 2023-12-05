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

namespace DatumZaposleni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Zaposleni> lista = new List<Zaposleni>();
            Zaposleni z = new Zaposleni();
            z.Ime = textBox1.Text;
            z.Prezime = textBox2.Text;
            z.DatumPrijave = dateTimePicker1.Value;
            z.DatumOdjave = dateTimePicker2.Value;
            lista.Add(z);
            textBox3.Text += z.ToString();

            string imeDatoteke = z.Ime.ToLower() + z.Prezime.ToLower();
            Text = imeDatoteke;

            StreamWriter sw = new StreamWriter(imeDatoteke + ".txt", true);
            z.pisi(sw);
            sw.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
