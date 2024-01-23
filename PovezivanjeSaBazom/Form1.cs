using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PovezivanjeSaBazom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Radnici_odeljenja_osiguranja1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand komanda = new SqlCommand();
            komanda.CommandText = textBox1.Text;
            komanda.Connection = konekcija;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komanda;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
