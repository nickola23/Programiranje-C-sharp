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

namespace Stack2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack red1 = new Stack(new int[] { 1, 2, 3, 4, 5, 6 });
        Stack red2 = new Stack(new int[] { });


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string broj = red1.Peek().ToString();
                red1.Pop();
                red2.Push(broj);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (var s in red1)
                {
                    listBox1.Items.Add(s);
                }
                foreach (var s in red2)
                {
                    listBox2.Items.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Stack je prazan", "GRESKA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string broj = red2.Peek().ToString();
                red2.Pop();
                red1.Push(broj);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (string s in red1)
                {
                    listBox1.Items.Add(s);
                }
                foreach (string s in red2)
                {
                    listBox2.Items.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Stack je prazan", "GRESKA");
            }
        }
    }
}
