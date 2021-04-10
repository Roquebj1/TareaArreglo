using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArchivo
    {
        //Investigar como abrir archivos UTF
        //Sacar promedio de cada uno de los parciales
        //Meter las notas a un arreglo y diga cual es la nota mas alta y baja y quien saco esa nota
        //Ordenar un arreglo de los nombre por el metodo de burbuja
        public string[] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;
        }

        public string LeerTodoArhivo(string archivo)
        {
            string ContenidoArchivo;
            using(StreamReader reader = new StreamReader(archivo))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }
    }
}
