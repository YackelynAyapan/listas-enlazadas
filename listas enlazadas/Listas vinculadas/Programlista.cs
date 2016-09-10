using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_vinculadas
{
    class Programlista
    {
        static void Main(string[] args)
        {
            Node List = new Node();
            Console.WriteLine("Ingrese 5 datos a la lista");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inserte el dato {0}", i+1);
                List.insertFirst(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("La lista quedo asi");
            List.imprimir();

            
            Console.WriteLine("\nModifique el dato de la lista");
            List.Modificar();
            Console.WriteLine("\nModificados son:");
            List.imprimir();
            Console.WriteLine("\nAhora borre el dato de la lista");
            List.Borrar();
            Console.WriteLine("\nEl listado ahora queda asi");
            List.imprimir();
            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
