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

namespace Stack1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack brojevi = new Stack(new int[] { 1, 2, 3, 4, 5, 6 });

        private void button1_Click(object sender, EventArgs e)
        {
            string ispis = "";
            foreach(int broj in brojevi)
            {
                ispis += broj.ToString() + "\n";
            }
            MessageBox.Show(ispis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0; 
            foreach(int num in brojevi)
            {
                i++;
            }
            brojevi.Push(i + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brojevi.Pop();
        }
    }
}
