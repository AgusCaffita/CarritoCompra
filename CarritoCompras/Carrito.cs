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
    }
}
