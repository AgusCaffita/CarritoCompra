using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }

        public Producto(int Codigo, string Nombre, double Precio, int Stock, Categoria Categoria)
        { 
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Categoria = Categoria;
        }
    }
}
