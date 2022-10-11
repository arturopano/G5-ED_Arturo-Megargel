using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlizadas
{
    internal class Principal
    {
        static void Main(String[] args)
        {
            Lista l = new Lista();
                int opcionMenu = 0;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("|  1. Inserta numero    |");
                Console.WriteLine("| 2. Eleminar           |");
                Console.WriteLine("| 3. Desplegar          |");
                Console.WriteLine("| 4. Salir del programa |");
                Console.WriteLine("------------------------");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Inserta Nodo en la lista");
                        l.insertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("Eleminar Nodo en la lista");
                        l.eliminarNodo();
                        break;
  
                    case 3:
                        Console.WriteLine("Desplegar la lista de los nodos");
                        l.desplegarLista();
                        break;
                    case 4:
                        Console.WriteLine("Cerrando pograma...");
                        break;
                    default:
                        Console.WriteLine("Opcion No valida");
                        break;


                }

            }
            while (opcionMenu != 4);
        }
    }
}
