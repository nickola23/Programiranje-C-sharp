using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumVremeDTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //maskedTextBox1.Text = dateTimePicker1.Value.ToShortDateString();
            maskedTextBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dateTimePicker2.Value = Convert.ToDateTime(maskedTextBox1.Text);
            monthCalendar2.MaxSelectionCount = 1;
            monthCalendar2.SelectionStart = Convert.ToDateTime(maskedTextBox1.Text);
        }
    }
}
