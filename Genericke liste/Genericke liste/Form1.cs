using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericke_liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista<string> lista = new Lista<string>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.nalaziSe(comboBox1))
                label2.Text = "Da";
            else label2.Text = "Ne";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.dodaj(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            lista.ispisi(listBox1, comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.obrni();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            lista.kopirajUNiz(listBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.brisi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lista.sortiraj();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lista.ubaci(Convert.ToInt32(textBox2.Text), textBox3.Text);
            button2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lista.sortiraj();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            lista.NovaLista(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), listBox2);
        }
    }
}
