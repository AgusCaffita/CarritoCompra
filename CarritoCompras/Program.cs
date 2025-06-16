using System;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda();
            Carrito carrito = new Carrito();
            
            Console.WriteLine("Bienvenido a la tienda online de La Panaderia Feliz");
            Console.WriteLine("\n        Qué quiere hacer hoy?");
            Console.WriteLine("\n1- Ver Catalogo \n2- Ver su carrito \n3-Ver categorias de productos \n4-Salir");
            string input = Console.ReadLine();
            int accion = int.Parse(input);

            switch (accion)
            {
                case 1:
                    tienda.VerProductos();
                    break;

                case 2:
                    carrito.VerCarrito();
                    break;

                case 3:
                    tienda.VerCategorias();                    
                    break;

                case 4:
                    carrito.FinalizarCompra();
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    break;
            }
            while (true)
            {
                Console.WriteLine("Que desea hacer a continuacion \n1- Agregar producto al carrito \n2- Eliminar producto de su carrito \n3-Ver el total a pagar \n4-Finalizar su compra \n5-Volver atras");
                string entrada = Console.ReadLine();
                int acc = int.Parse(entrada);
                string prod, Cantidad;
                int cod=0, cant=0;
            
                switch (acc)
                {
                    case 1:

                        Console.WriteLine("Ingrese codigo del producto");
                        prod = Console.ReadLine();
                        cod = int.Parse(prod);
                        Console.WriteLine("Ingrese la cantidad que desea");
                        Cantidad = Console.ReadLine();
                        cant = int.Parse(Cantidad);
                        for (int i = 0; i < tienda.productos.Count; i++)
                        {
                            if (tienda.productos[i].Codigo == cod)
                                carrito.Agregar(cod, cant, tienda.productos[i]);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Ingrese codigo del producto");
                        prod = Console.ReadLine();
                        cod = int.Parse(prod);
                        carrito.Eliminar(cod);
                        break;

                    case 3:
                        carrito.TotalPagar();
                        break;

                    case 4:
                        carrito.FinalizarCompra();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Numero no valido");
                        break;
                }
                carrito.VerCarrito();
            }
            

        }
    }
}
