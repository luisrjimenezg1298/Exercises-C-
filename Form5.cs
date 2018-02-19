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
    public partial class frmCasaCambio : Form
    {
        double dolar;
        double euro;
        double libra;
        double bolivar;
        double yen;
        double colombia;
        public frmCasaCambio()
        {
            InitializeComponent();
        }

        private void frmCasaCambio_Load(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dolar = double.Parse(textBox4.Text) * 45;
            textBox5.Text = dolar.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            euro = double.Parse(textBox6.Text) * 51;
            textBox7.Text = euro.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            libra = double.Parse(textBox8.Text) * 63;
            textBox9.Text = libra.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bolivar = double.Parse(textBox10.Text) * 0.01;
            textBox11.Text = bolivar.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            colombia = double.Parse(textBox14.Text) * 0.01;
            textBox15.Text = bolivar.ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            yen = double.Parse(textBox12.Text) * 0.40;
            textBox13.Text = yen.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox1.Focus();
        }
    }
}
