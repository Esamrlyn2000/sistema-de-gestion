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

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int fila = dgvEstudiantes.CurrentRow.Index;
            string nombre =dgvEstudiantes.Rows[fila].Cells[0].Value.ToString();  
            string apellidop =dgvEstudiantes.Rows[fila].Cells[1].Value.ToString();  
            string apellidom = dgvEstudiantes.Rows[fila].Cells[2].Value.ToString();
            Form1 frm = new Form1();
            frm.txtNombre.Text = nombre;
            frm.txtApaterno.Text = apellidop;
            frm.txtAmaterno.Text = apellidom;
            frm.txtDireccion.Enabled = false;
            frm.txtTelefono.Enabled = false;

            frm.ShowDialog();*/
           
            
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
