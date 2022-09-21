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
            Form1 form1 = new Form1();
            form1.loadEstudiante(new ClsEstudiante 
            {
                idEstudiante = dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                nombre = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                aPaterno = dgvEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                aMaterno = dgvEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                fechaNc = dgvEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString(),
                Telefono = dgvEstudiantes.Rows[e.RowIndex].Cells[5].Value.ToString(),
                direccion = dgvEstudiantes.Rows[e.RowIndex].Cells[6].Value.ToString(),
                nombrePadre = dgvEstudiantes.Rows[e.RowIndex].Cells[7].Value.ToString(),
                nombreMadre = dgvEstudiantes.Rows[e.RowIndex].Cells[8].Value.ToString(),
                foto = (byte[])dgvEstudiantes.Rows[e.RowIndex].Cells[9].Value
            });
            form1.Show(this);
            
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

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbFoto.Image = Image.FromStream(ClsEstudiante.ByteToImagen((byte[])dgvEstudiantes.Rows[e.RowIndex].Cells[9].Value));
        }
    }
}
