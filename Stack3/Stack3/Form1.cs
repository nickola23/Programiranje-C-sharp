using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassStek<string> ucenici = new ClassStek<string>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void button1_Click(object sender, EventArgs e)
        {
            ucenici.dodaj(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            ucenici.ispisi(listBox1, comboBox1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ucenici.ukloni();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = ucenici.naVrhu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ucenici.kopirajNiz(listBox2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ucenici.brisiStek();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {       }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ucenici.nalaziSe(comboBox1))
                label3.Text = "Da";
            else label3.Text = "Ne";
        }
    }
}
