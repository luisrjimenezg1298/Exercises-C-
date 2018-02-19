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
    public partial class frmArea : Form
    {
        double bas;
        double altura;
        double area;

        public frmArea()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bas = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);
            area = bas * altura / 2;
            textBox3.Text = area.ToString();
        }
    }
}
