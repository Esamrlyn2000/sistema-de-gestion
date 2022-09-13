using MySql.Data.MySqlClient;
using sistema_de_gestion_academica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestion_academica
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        void actualizarGrid() 
        {  
            dgvEstudiantes.DataSource = conexion.actualizagrib();
        }
    }
}
