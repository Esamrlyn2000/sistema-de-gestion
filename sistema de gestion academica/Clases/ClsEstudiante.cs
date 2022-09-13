using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing;

namespace sistema_de_gestion_academica.Clases
{
    internal class ClsEstudiante
    {
        public string nombre;
        public string aPaterno;
        public string aMaterno;
        public string fechaNc;
        public string Telefono;
        public string direccion;
        public string nombrePadre;
        public string nombreMadre;
        public string categoria;

        //Convierte Byte a Imagen
        public static MemoryStream ByteToImagen(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }
        //Coverte de Imagen a byte
        public static byte[] imageToByte(Image imagenIn)
        {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}
