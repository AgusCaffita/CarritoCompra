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

        public Tienda()
        {
            
            
            categorias.Add(new Categoria("Panes", "Los mas crujientes"));
            categorias.Add(new Categoria("Tortas", "despues la pensamos"));
            categorias.Add(new Categoria("Galletitas", "despues la pensamos"));
            categorias.Add(new Categoria("Sin TACC", "despues la pensamos"));

            productos.Add(new Producto(011, "Pan de semillas", 10.5, 4, categorias[0]));
            productos.Add(new Producto(012, "Pan blanco", 9.3, 13, categorias[0]));
            productos.Add(new Producto(013, "Pan negro", 11.8, 15, categorias[0]));
            productos.Add(new Producto(111, "Brownie", 8, 8, categorias[1]));
            productos.Add(new Producto(112, "Tofi", 12.5, 16, categorias[1]));
            productos.Add(new Producto(113, "Chaja", 13.7, 4, categorias[1]));
            productos.Add(new Producto(211, "Pepas", 5.5, 30, categorias[2]));
            productos.Add(new Producto(212, "Galletitas con chips de chocolate", 4.99, 40, categorias[2]));
            productos.Add(new Producto(213, "Galletitas de Manteca", 3.2, 35, categorias[2]));
            productos.Add(new Producto(311, "Chipa", 14.4, 6, categorias[3]));
            productos.Add(new Producto(312, "Pastafrola", 15, 12, categorias[3]));

            
        }
    }
}
