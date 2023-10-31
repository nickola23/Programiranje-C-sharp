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

namespace Datoteke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                StreamWriter sw = new StreamWriter(textBox1.Text + ".txt", true);
                sw.WriteLine(textBox2.Text);
                textBox2.Text = "";
                textBox1.Enabled = false;
                sw.Close();
                textBox2.Focus();
            }
            else
                throw new Exception("Morate uneti podatke");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(textBox1.Text + ".txt");
            string s;
            listBox1.Items.Clear();
            s = sr.ReadLine();
            while(s != null)
            {
                listBox1.Items.Add(s);
                s = sr.ReadLine();
            }
            sr.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
            StreamReader sr = new StreamReader(textBox1.Text + ".txt");
            string s;
            int max, x;
            s = sr.ReadLine();
            max = Convert.ToInt32(s);
            while (s != null)
            {
                s = sr.ReadLine();
                x = Convert.ToInt32(s);
                if(x > max) max = x;
            }
            sr.Close();
            label4.Text = "Max broj je " + max;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                StreamReader sr = new StreamReader(textBox1.Text + ".txt");
                string s;
                int sum, n = 1, x;
                s = sr.ReadLine();
                sum = Convert.ToInt32(s);
                while (s != null)
                {
                    s = sr.ReadLine();
                    sum += Convert.ToInt32(s);
                }
                sr.Close();
                label4.Text = "Suma je " + sum;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                StreamReader sr = new StreamReader(textBox1.Text + ".txt");
                string s;
                int sum, n = 1, x;
                s = sr.ReadLine();
                sum = Convert.ToInt32(s);
                while (s != null)
                {
                    s = sr.ReadLine();
                    sum += Convert.ToInt32(s);
                    n++;
                }
                sr.Close();
                label4.Text = "Prosek je " + (double)sum/(double)n;
            }
        }
    }
}
