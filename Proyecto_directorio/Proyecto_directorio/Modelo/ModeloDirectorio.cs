using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_directorio
{
    class ModeloDirectorio
    {
        private string directorio;

        public ModeloDirectorio(string nomDirectorio)
        {
            directorio = nomDirectorio;
        }

        public string[] cargararchivos()
        {
            return Directory.GetFiles(directorio);
        }
    }
}
