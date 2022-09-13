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
            string fechaN = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            byte[] miFoto = ClsEstudiante.imageToByte(pbImagen.Image); ;


            MySqlConnection conexionBD = conexion.ObtenerConexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionBD;
            comando.CommandText = ("insert into tb_estudiante (nombre,apaterno,amaterno,fecha,telefono,direccion,npaterno,nmaterno,Foto) values('" + txtNombre.Text + "','" + txtApaterno.Text + "','" + txtAmaterno.Text + "','" + fechaN + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','" + txtNpaterno.Text + "','" + txtNmaterno.Text + "','"+miFoto+"');");
            comando.ExecuteNonQuery();
            conexionBD.Close();
            MessageBox.Show("Datos Registrado Correctamente");
            txtNombre.Text = ""; 
            txtApaterno.Text = "";
            txtAmaterno.Text = "";
            txtDireccion.Text = "";
            txtNmaterno.Text = "";
            txtNpaterno.Text = "";
            txtTelefono.Text = "";
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione una imagen";
            dialog.Filter = "*.jpg|*.jpg";
            dialog.InitialDirectory = "C:\\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = dialog.FileName;
            }
        }
    }
}
