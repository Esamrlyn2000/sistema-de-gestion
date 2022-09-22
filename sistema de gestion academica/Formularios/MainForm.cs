using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestion_academica.Formularios
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.UtcNow.Date.ToString("MMMM-dd-yyyy");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Estudiante registrado con exito");
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion frm = new frmConfiguracion();
            frm.ShowDialog();
        }
    }
}
