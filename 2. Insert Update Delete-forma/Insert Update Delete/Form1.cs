using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insert_Update_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection konekcija;
        SqlCommand komanda, komanda1;
        DataTable dt;
        SqlDataAdapter da;
      
        void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Radnici_odeljenja_osiguranja1.mdf;Integrated Security=True;Connect Timeout=30";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            dt = new DataTable();
            da = new SqlDataAdapter();
        }

        List<Radnik> lista = new List<Radnik>();
     
        private void Form1_Load(object sender, EventArgs e)
        {
            Konekcija();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            komanda.CommandText = "SELECT * FROM radnici";
            da.SelectCommand = komanda;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Radnik r;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                r = new Radnik();
                r.ID = Convert.ToInt32(dt.Rows[i][0]);
                r.Ime = Convert.ToString(dt.Rows[i][1]);
                r.Prezime = Convert.ToString(dt.Rows[i][2]);
                r.Plata = Convert.ToDouble(dt.Rows[i][3]);
                r.Brod = dt.Rows[i][4] == (Object)DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i][4]);
                r.Idos = Convert.ToInt32(dt.Rows[i][5]);
                if (!comboBox1.Items.Contains(dt.Rows[i][4]) && dt.Rows[i][4] != DBNull.Value)
                {
                    comboBox1.Items.Add(dt.Rows[i][4]);
                }
                if (!comboBox2.Items.Contains(dt.Rows[i][5]))
                {
                    comboBox2.Items.Add(dt.Rows[i][5]);
                }
            }
            if (!comboBox1.Items.Contains("-"))
            {
                comboBox1.Items.Add("-");
            }
            konekcija.Close();
        }
        
        public bool postoji()
        {
            int i;
            bool postoji = false;
            for(i= 0;  i < lista.Count; i++)
            {
                if(Convert.ToInt32(textBox1.Text) == lista[i].ID)
                {
                    postoji = true;
                    break;
                }
            }
            return postoji;
        }
      
        //INSERT
        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "INSERT INTO radnici (idbr, ime, prezime, plata, brod, idos) VALUES (@idbr, @ime, @prezime, @plata, @brod, @idos)";

            komanda.Parameters.AddWithValue("@idbr", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@prezime",textBox3.Text);
            komanda.Parameters.AddWithValue("@plata", Convert.ToInt32(textBox4.Text));
            if(comboBox1.Text == "-")
            {
                komanda.Parameters.AddWithValue("@brod", DBNull.Value);
            }
            else
            {
                komanda.Parameters.AddWithValue("@brod",comboBox1.Text);
            }
            komanda.Parameters.AddWithValue("@idos", comboBox2.Text);
            try
            {
                if (!postoji())
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podatak dodat u bazu");
                }
                else
                {
                    MessageBox.Show("Podatak postoji u bazi");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
            finally
            {
                konekcija.Close();
            }
            Form1_Load(sender, e);
        }


        //UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "UPDATE radnici SET  ime = @ime, prezime = @prezime, plata = @plata, brod = @brod, idos = @idos WHERE idbr = @idbr";

            komanda.Parameters.AddWithValue("@idbr", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@prezime", textBox3.Text);
            komanda.Parameters.AddWithValue("@plata", Convert.ToInt32(textBox4.Text));
            if (comboBox1.Text == "-")
            {
                komanda.Parameters.AddWithValue("@brod", DBNull.Value);
            }
            else
            {
                komanda.Parameters.AddWithValue("@brod", comboBox1.Text);
            }
            komanda.Parameters.AddWithValue("@idos", comboBox2.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Podatak izmenjen u bazi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
                textBox1.Focus();
            }
            finally
            {
                konekcija.Close();
            }
            Form1_Load(sender, e);
        }
        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            komanda.CommandText = "DELETE FROM radnici WHERE idbr = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                konekcija.Open();
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Da li zaista zelite da izaberete podatak iz baze", "Izlaz", MessageBoxButtons.YesNoCancel);
                if(dr == DialogResult.Yes)
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podatak je izbrisan iz baze", "Obavestenje");
                }
                else if(dr == DialogResult.No || dr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Izaberi podatak koji zelis da izaberes");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
            finally
            {
                konekcija.Close();
            }
            Form1_Load(sender, e);
        }
        //veza između vrednosti u dataGridView1 i textBox, comboBox
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //UCITAJ SVE
        private void button4_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        //ANALIZA
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.ShowDialog();        
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
