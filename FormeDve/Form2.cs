using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormeDve
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int A
        {
            get {
                return a;
            } 
            set{
                textBox1.Text = value.ToString();
                a = value;
            }
        }
        public int B
        {
            get{
                return b;
            }
            set{
                textBox2.Text = value.ToString();
                b = value;
            }
        }
        int a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            // textBox1.Text = a.ToString();
            // textBox2.Text = b.ToString();
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(Color.Black, 2);
            g.DrawLine(olovka, 0, 0, A, B);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty; 
            textBox2.Text = string.Empty;
            pictureBox1.Refresh();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            this.Close();
        }


    }
}
