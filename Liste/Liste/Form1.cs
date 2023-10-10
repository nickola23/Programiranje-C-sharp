using System.Collections;

namespace Liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue lista = new Queue();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Enqueue(textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            string text = lista.Peek().ToString();
            lista.Dequeue();
            textBox2.Text = text;
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var red in lista)
            {
                listBox1.Items.Add(red.ToString());
            }
        }
    }
}