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

            productos.Add(new Producto(111, "Pan de semillas", 10.5, 4, categorias[0]));
            productos.Add(new Producto(112, "Pan blanco", 9.3, 13, categorias[0]));
            productos.Add(new Producto(113, "Pan negro", 11.8, 15, categorias[0]));
            productos.Add(new Producto(211, "Brownie", 8, 8, categorias[1]));
            productos.Add(new Producto(212, "Tofi", 12.5, 16, categorias[1]));
            productos.Add(new Producto(213, "Chaja", 13.7, 4, categorias[1]));
            productos.Add(new Producto(311, "Pepas", 5.5, 30, categorias[2]));
            productos.Add(new Producto(312, "Galletitas con chips de chocolate", 4.99, 40, categorias[2]));
            productos.Add(new Producto(313, "Galletitas de Manteca", 3.2, 35, categorias[2]));
            productos.Add(new Producto(411, "Chipa", 14.4, 6, categorias[3]));
            productos.Add(new Producto(412, "Pastafrola", 15, 12, categorias[3]));         
        }

        public void VerCategorias()
        {
            Console.WriteLine("\nCategorias\n");
            for(int i = 0; i < categorias.Count; i++)
            {
                Console.WriteLine((i+1) + "_ " + categorias[i].Nombre + "\n  " + categorias[i].Descripcion);
            }
            Console.WriteLine(categorias.Count+1 + "_ Volver atras");
            string input = Console.ReadLine();
            int accion = int.Parse(input);
            switch (accion)
            {
                case int i when (i>0 && i<=categorias.Count):
                    VerProdFiltrados(accion);
                    break;

                case int i when (i == categorias.Count+1):
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
        }
        public void VerProductos()
        {
            Console.WriteLine("\nProductos\n");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine(productos[i].Nombre + " " + productos[i].Codigo + "\n Precio $" + productos[i].Precio + " quedan " + productos[i].Stock + "\n");
            }
        }
        public void VerProdFiltrados(int num)
        {
            Categoria categoriaSeleccionada = categorias[num - 1];
            Console.WriteLine($"\nProductos en categoría: {categoriaSeleccionada.Nombre}\n");

            bool hayProductos = false;
            foreach (var producto in productos)
            {
                if (producto.Categoria == categoriaSeleccionada)
                {
                    Console.WriteLine($" {producto.Nombre} ({producto.Codigo}) - ${producto.Precio} - Stock: {producto.Stock}");
                    hayProductos = true;
                }
            }
            if (!hayProductos)
            {
                Console.WriteLine("No hay productos en esta categoría.");
            }
        }

    }
}
