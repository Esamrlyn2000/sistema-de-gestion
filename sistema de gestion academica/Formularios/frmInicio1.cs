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
    public partial class frmInicio1 : Form
    {
        private frmConfiguracion frmConfiguracion;

        public frmInicio1()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmConfiguracion frm = new frmConfiguracion();
            frm.ShowDialog();

        }
    }
}
