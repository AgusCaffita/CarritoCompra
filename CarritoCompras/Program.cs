using System;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Bienvenido a la tienda online de La Panaderia Feliz");
            Console.WriteLine("\n        Qué quiere hacer hoy?");
            Console.WriteLine("\n1- Ver Catalogo \n2- Ver su carrito \n3-Ver categorias de productos \n4-Salir");
            int accion = Console.ReadLine("Ingrese el numero de lo que desea hacer: ");
            Console.WriteLine(accion);
        }
    }
}
