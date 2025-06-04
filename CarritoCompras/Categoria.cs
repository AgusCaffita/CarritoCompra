using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Categoria
    {
        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public void Categoria(string nombre, string desc)
        {
            this.Nombre = nombre;
            Descripcion = desc;
        }
    }
}
