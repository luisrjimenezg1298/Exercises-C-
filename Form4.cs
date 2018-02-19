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
    public partial class frmCalificaciones : Form
    {
        int prom;
        int examen;
        int promN;
        int setentaP;
        int final;
        int exa;
        
        public frmCalificaciones()
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            prom = int.Parse(txtNota1.Text) + int.Parse(txtNota2.Text) + int.Parse(txtNota3.Text) + int.Parse(txtNota4.Text);
            promN = prom / 4;
            txtPromedio.Text = promN.ToString();
            setentaP = prom / 4 * 70 / 100;
            txtSetenta.Text = setentaP.ToString();
            examen = int.Parse(txtExamen.Text);
            exa = examen * 30 / 100;
            txtTreinta.Text = exa.ToString();
            final = exa + setentaP;
            txtFinal.Text = final.ToString();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
            txtSetenta.Clear();
            txtTreinta.Clear();
            txtExamen.Clear();
            txtFinal.Clear();
            textBox1.Focus();
        
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
