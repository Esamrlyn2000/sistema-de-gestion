using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestion_academica.Formularios
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes();
            frm.ShowDialog();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes();
            frm.ShowDialog();
        }
    }
}
