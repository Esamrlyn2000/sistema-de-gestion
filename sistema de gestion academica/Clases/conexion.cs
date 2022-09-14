using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_de_gestion_academica.Clases
{
    public static class conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string servidor = "server = localhost; database = db_sysregistro; Uid = root; pwd =;";
            MySqlConnection conectar = new MySqlConnection(servidor);

            try
            {
                return conectar;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message+e.StackTrace);
                return null;
            }
            
        }

        public static void Insertar(this ClsEstudiante estudiante)
        {
            try
            {
                MySqlConnection conexionBD = conexion.ObtenerConexion();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexionBD;
                comando.CommandText = "sp_setEstudiante";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", estudiante.nombre);
                comando.Parameters.AddWithValue("@apaterno", estudiante.aPaterno);
                comando.Parameters.AddWithValue("@amaterno", estudiante.aMaterno);
                comando.Parameters.AddWithValue("@fecha", estudiante.fechaNc);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.Parameters.AddWithValue("@direccion", estudiante.direccion);
                comando.Parameters.AddWithValue("@npaterno", estudiante.nombrePadre);
                comando.Parameters.AddWithValue("@nmaterno", estudiante.nombreMadre);
                comando.Parameters.AddWithValue("@categoria", estudiante.categoria);
                comando.Parameters.AddWithValue("@foto", estudiante.foto);
                comando.Parameters.AddWithValue("@idEstudiante", estudiante.idEstudiante);

                //comando.CommandText = ("insert into tb_estudiante (nombre,apaterno,amaterno,fecha,telefono,direccion,npaterno,nmaterno,Foto) values('" + txtNombre.Text + "','" + txtApaterno.Text + "','" + txtAmaterno.Text + "','" + fechaN + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','" + txtNpaterno.Text + "','" + txtNmaterno.Text + "','"+miFoto+"');");
                conexionBD.Open();
                comando.ExecuteNonQuery();
                conexionBD.Close();
                MessageBox.Show("Datos Registrado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable actualizagrib()
        {
            MySqlConnection conexionBD = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexionBD;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getEstudiante";

            conexionBD.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
               
                adapter.Fill(dt);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        
        public static int obtenerContador()
        {
            MySqlConnection conn = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "sp_cuentaEstudiante";
            cmd.CommandText = "sp_getUltimo";
            MySqlDataReader dr;

            int resultado = 0;

            try
            {
                conn.Open();

                dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    resultado = dr.GetInt16(0);
                }                             
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            finally { conn.Close(); }

            return resultado;

 
            

            

        }




    }
}
