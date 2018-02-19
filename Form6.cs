using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBasicoColon
{
    public partial class frmCalculadora : Form
    {
        double x;
        double y;
        double n;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f2 = new frmMenu();
            f2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            n = x + y;
            textBox3.Text = n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            n = x - y;
            textBox3.Text = n.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            n = x * y;
            textBox3.Text = n.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            n = x / y;
            textBox3.Text = n.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
