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
    public partial class frmNomina : Form {
    
        double sb;
         double des;
         double sn;
    
        public frmNomina()
        {
            InitializeComponent();
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f2 = new frmMenu();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sb= double.Parse(txtSueldoBruto.Text);
            des= double.Parse(txtDescuento.Text);
            sn = sb - des;
            txtSueldoNeto.Text = sn.ToString();
                      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
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
            txtSueldoBruto.Clear();
            txtDescuento.Clear();
            textBox1.Focus();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
