using sistema_de_gestion_academica.Properties;
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
using MySql.Data.MySqlClient;

namespace sistema_de_gestion_academica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            ClsEstudiante estudiante = new ClsEstudiante();


            string fechaN = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            byte[] miFoto = ClsEstudiante.imageToByte(pbImagen.Image); ;
            string categoria = null;


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
            conexion.Insertar(estudiante);

            limpiaCampos();
           
           
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione una imagen";
            dialog.Filter = "PNG(*.PNG)|*.PNG|JPG(*.JPG)|*.JPG|JPEG(*.JPEG)|*.JPEG|Todos los formatos|*.*";
            dialog.InitialDirectory = "C:\\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = dialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes();
            frm.ShowDialog(); 

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
            pbImagen.Image = Resources.blank_profile_picture_g6969457f6_1280;
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
