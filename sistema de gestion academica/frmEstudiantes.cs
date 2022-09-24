using MySql.Data;
using MySql.Data.MySqlClient;
using sistema_de_gestion_academica.Properties;
using sistema_de_gestion_academica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources = sistema_de_gestion_academica.Properties.Resources;

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
            lblTotal.Text = dgvEstudiantes.RowCount.ToString();
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Enabled = true;
            txtApaterno.Enabled = true;
            txtAmaterno.Enabled = true;
            dtpNacimiento.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtNpaterno.Enabled = true;
            txtNmaterno.Enabled = true;
            btnSelec.Enabled = true;
            lblMatricula.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpNacimiento.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefono.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNpaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNmaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[8].Value.ToString();
            pbFoto.Image = Image.FromStream(ClsEstudiante.ByteToImagen((byte[])dgvEstudiantes.Rows[e.RowIndex].Cells[9].Value));





            /*Form1 form1 = new Form1();
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
            lblMatricula.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpNacimiento.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefono.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNpaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNmaterno.Text = dgvEstudiantes.Rows[e.RowIndex].Cells[8].Value.ToString();
            pbFoto.Image = Image.FromStream(ClsEstudiante.ByteToImagen((byte[])dgvEstudiantes.Rows[e.RowIndex].Cells[9].Value));
            txtNombre.Enabled = false;
            txtApaterno.Enabled = false;
            txtAmaterno.Enabled = false;
            dtpNacimiento.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtNpaterno.Enabled = false;
            txtNmaterno.Enabled = false;
            btnSelec.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsEstudiante estudiante = new ClsEstudiante();


            string fechaN = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            byte[] miFoto = ClsEstudiante.imageToByte(pbFoto.Image); ;
            string categoria = null;
            if (lblMatricula.Text == "Matricula")
            {
                estudiante.nombre = txtNombre.Text;
                estudiante.aPaterno = txtApaterno.Text;
                estudiante.aMaterno = txtAmaterno.Text;
                estudiante.fechaNc = fechaN;
                estudiante.Telefono = txtTelefono.Text;
                estudiante.direccion = txtDireccion.Text;
                estudiante.nombrePadre = txtNpaterno.Text;
                estudiante.nombreMadre = txtNmaterno.Text;
                estudiante.categoria = categoria;
                estudiante.foto = miFoto;
                estudiante.idEstudiante = ClsEstudiante.validaCodigo();
                conexion.Insertar(estudiante);
            }
            else
            {
                estudiante.nombre = txtNombre.Text;
                estudiante.aPaterno = txtApaterno.Text;
                estudiante.aMaterno = txtAmaterno.Text;
                estudiante.fechaNc = fechaN;
                estudiante.Telefono = txtTelefono.Text;
                estudiante.direccion = txtDireccion.Text;
                estudiante.nombrePadre = txtNpaterno.Text;
                estudiante.nombreMadre = txtNmaterno.Text;
                estudiante.categoria = categoria;
                estudiante.foto = miFoto;
                estudiante.idEstudiante = lblMatricula.Text;
                conexion.actualizaEstudiante(estudiante);
            }

            limpiaCampos();
            DialogResult = DialogResult.OK;
            actualizarGrid();
        }

        private void limpiaCampos()
        {
            txtNombre.Text = "";
            txtApaterno.Text = "";
            txtAmaterno.Text = "";
            txtDireccion.Text = "";
            txtNmaterno.Text = "";
            txtNpaterno.Text = "";
            txtTelefono.Text = "";
            pbFoto.Image = Resources.blank_profile_picture_g6969457f6_1280;
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione una imagen";
            dialog.Filter = "PNG(*.PNG)|*.PNG|JPG(*.JPG)|*.JPG|JPEG(*.JPEG)|*.JPEG|Todos los formatos|*.*";
            dialog.InitialDirectory = "C:\\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = dialog.FileName;
            }
        }

        private void EliminarLinea()
        {
            int fila = dgvEstudiantes.CurrentRow.Index;
            DataGridViewRow dr = new DataGridViewRow();
            if (dr != null)
            {
                if(txtNombre.Enabled == true && !string.IsNullOrEmpty(txtNombre.Text))
                {
                    conexion.eliminaEstudiantes(dgvEstudiantes.Rows[fila].Cells[0].Value.ToString());
                    limpiaCampos();
                    actualizarGrid();

                }else
                {
                    MessageBox.Show("Debe cargar los datos primero", "Notificaion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estudiantes", "Notificaion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            EliminarLinea();

            //if (lblMatricula.Text == "Matricula" && txtNombre.Visible != false)
            //{

            //}
            //else
            //{

            //}

        }
    }
}
