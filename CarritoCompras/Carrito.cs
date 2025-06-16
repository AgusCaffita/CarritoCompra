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

        public Carrito()
        {

        }
        public void Agregar(int cod, int cant)
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
                items[i + 1].Cantidad = cant;
                items[i + 1].Producto.Codigo = cod;
            }
        }

        public void Eliminar(int cod)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (cod == items[i].Producto.Codigo)
                {
                    items.RemoveAt(i);
                    i = items.Count;
                }
            }
        }
        public void VerCarrito()
        {
            Console.WriteLine("El carrito tiene");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Producto.Nombre + " " + items[i].Cantidad);
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
            total = total + (total * 0.79);
            Console.WriteLine("El total de su compra es: " + total);
        }
        public void FinalizarCompra()
        {
            TotalPagar();
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < productos.Count; j++)
                {
                    if(items[i].Producto.Codigo == productos.Codigo)
                    {
                        productos.Stock -= items[i].Cantidad;
                    }
                }
            }
        }

    }
}
