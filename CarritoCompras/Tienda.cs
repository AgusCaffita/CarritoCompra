using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Tienda
    {
        public List<Categoria> categorias { get; set; }= new List<Categoria>();
        public List<Producto> productos { get; set; }= new List<Producto>();

        public void Tienda()
        {
            
            
            categorias.Add(new Categoria("Panes", "despues la pensamos"));
            categorias.Add(new Categoria("Tortas", "despues la pensamos"));
            categorias.Add(new Categoria("Galletitas", "despues la pensamos"));

            productos.Add(new Producto(111, "Pan de semillas", 10.5, 4, categorias[0]));
            productos.Add(new Producto(111, "Pan blanco", 10.5, 4, categorias[0]));
        }
    }
}
