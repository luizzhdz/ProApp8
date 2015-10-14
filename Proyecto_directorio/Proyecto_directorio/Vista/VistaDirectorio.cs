using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_directorio
{
    class VistaDirectorio
    {
        public void mostrarArchivos(ModeloDirectorio directorio, ListView lista)
        {
            string[] archivos = directorio.cargararchivos();
            foreach (string ruta in archivos)
            {
                FileInfo archivo = new FileInfo(ruta);
                int imagen;
                switch (archivo.Extension)
                {
                    case ".xls":
                    case ".xlsx": imagen = 0;
                        break;
                    case ".jnp":
                    case ".png": imagen = 1;
                        break;
                    case ".pdf": imagen = 2;
                        break;
                    case ".ppt":
                    case ".pptx": imagen = 3;
                        break;
                    case ".doc":
                    case ".docx": imagen = 4;
                        break;
                    default: imagen = 5;
                        break;
                }
                lista.Items.Add(archivo.Name, imagen);
            }
                    
        }
    }
}
