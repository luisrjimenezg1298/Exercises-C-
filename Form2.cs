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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lista2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lista1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmNomina();
            f2.Show();
            this.Hide();

        }

        private void casaDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmCasaCambio();
            f2.Show();
            this.Hide();

        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmCalificaciones();
            f2.Show();
            this.Hide();

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmCalculadora();
            f2.Show();
            this.Hide();

        }

        private void areaDeUnTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmArea();
            f2.Show();
            this.Hide();

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
