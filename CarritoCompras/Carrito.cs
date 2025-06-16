using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Carrito
    {
        public List<ItemCarrito> items { get; set; } = new List<ItemCarrito>();

        public void Agregar(int cod, int cant, Producto producto)
        {
            int i = 0;
            for (i = 0; i < items.Count; i++)
            {
                if (cod == items[i].Producto.Codigo)
                {
                    items[i].Cantidad += cant;
                    i = items.Count + 1;
                }
            }
            if (i == items.Count)
            {
                items.Add(new ItemCarrito(producto, cant));
            }
        }

        public void Eliminar(int cod)
        {
            int i = 0;
            for (i = 0; i < items.Count; i++)
            {
                if (cod == items[i].Producto.Codigo)
                {
                    items.RemoveAt(i);
                    i = items.Count+1;
                }
            }
            if (i == items.Count)
            {
                Console.WriteLine("Ese producto no se encuentra en el carrito");
            }

        }
        public void VerCarrito()
        {
            Console.WriteLine("El carrito tiene");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Producto.Nombre + " " + items[i].Cantidad);
            }
            if (items.Count == 0)
            {
                Console.WriteLine("...nada");
            }
        }
        public void TotalPagar()
        {
            double total = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Cantidad >= 5)
                {
                    total += (items[i].Producto.Precio * 0.85 * items[i].Cantidad);
                }
                else
                {
                    total += (items[i].Producto.Precio * items[i].Cantidad);
                }  
            }
            total = total + (total * 0.21);
            Console.WriteLine("El total de su compra es: " + total);
        }
        public void FinalizarCompra(List<Producto>prod)
        {
            TotalPagar();
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < prod.Count; j++)
                {
                    if(items[i].Producto.Codigo == prod[j].Codigo)
                    {
                        prod[j].Stock = prod[j].Stock - items[i].Cantidad;
                    }
                }
            }
            Console.WriteLine("Realizando pago...");
        }

    }
}
