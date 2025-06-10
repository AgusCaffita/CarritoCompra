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
            string input = Console.ReadLine();
            int accion = int.Parse(input);

            switch (accion)
            {
                case 1:
                    Console.WriteLine("pusiste 1");
                    break;

                case 2:
                    Console.WriteLine("pusiste 2");
                    break;

                case 3:
                    Console.WriteLine("pusiste 3");
                    break;

                case 4:
                    Console.WriteLine("pusiste 4");
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
        }
    }
}
