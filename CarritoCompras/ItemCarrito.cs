﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class ItemCarrito
    {
        public Producto Producto { get; set; } 
        public int Cantidad { get; set; } 

        public ItemCarrito(Producto Producto, int cant)
        {
            this.Producto = Producto;
            Cantidad = cant;
        }
    }
}
