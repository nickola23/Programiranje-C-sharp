using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashtabele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Hashtable tabela = new Hashtable();

        private void button1_Click(object sender, EventArgs e)
        {
            tabela.Add(textBox2.Text, textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            comboBox1.Items.Clear();
            foreach (var hash in tabela.Keys)
            {
                comboBox1.Items.Add(hash.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var hash in tabela.Values)
            {
                listBox1.Items.Add(hash.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = tabela[comboBox1.SelectedIndex.ToString()].ToString();
        }
    }
}
