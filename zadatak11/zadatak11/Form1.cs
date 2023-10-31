using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Dodeli(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            textBox4.Text = student.Prikazi();
            if (student is IOsoba)
                Text = "to je to";
        }
    }
}
