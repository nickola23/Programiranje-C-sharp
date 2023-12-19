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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 forma2;
        private void button1_Click(object sender, EventArgs e)
        {
            forma2 = new Form2();
            forma2.Show();
            forma2.A = Convert.ToInt32(textBox1.Text);
            forma2.B = Convert.ToInt32(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y;
            x = forma2.A; 
            y = forma2.B;
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(Color.Black, 2);
            g.DrawLine(olovka, 0, 0, x, y);
            Text = x + " " + y;
        }
    }
}
