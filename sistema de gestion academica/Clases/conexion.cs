using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_de_gestion_academica.Clases
{
    public class conexion
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
    }
}
