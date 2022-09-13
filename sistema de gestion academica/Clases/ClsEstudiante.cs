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
    public class ClsEstudiante
    {
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string fechaNc { get; set; }
        public string Telefono { get; set; }
        public string direccion { get; set; }
        public string nombrePadre { get; set; }
        public string nombreMadre { get; set; }
        public string categoria { get; set; }
        public byte[] foto { get; set; }

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
