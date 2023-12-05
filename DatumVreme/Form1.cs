using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumVreme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dan, sat, min, sec;

            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt3 = DateTime.Now;

            int sec1 = dateTimePicker2.Value.Hour * 3600 + dateTimePicker2.Value.Minute * 60 + dateTimePicker2.Value.Second;

            textBox1.Text = dt3.ToShortDateString();
            textBox2.Text = dt3.ToShortTimeString();

            int sec2 = dt3.Hour * 3600 + dt3.Minute * 60 + dt3.Second;

            if(sec2 >= sec1)
            {
                dan = (dt3 - dt1).Days;
                sat = (sec2 - sec1) / 3600;
                min = (sec2 - sec1) % 3600 / 60;
                sec = (sec2 - sec1) % 3600 % 60;
            }
            else
            {
                dan = (dt3 - dt1).Days - 1;
                sat = ((24 * 3600 - sec1) + sec2) / 3600;
                min = ((24 * 3600 - sec1) + sec2) % 3600 / 60;
                sec = ((24 * 3600 - sec1) + sec2) % 3600 
                    % 60;

            }

            textBox3.Text = dan + " dana " + sat + " sati " + min + " minuta " + sec + " sekindi ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString("hh:mm:ss") + " " + dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }
    }
}
