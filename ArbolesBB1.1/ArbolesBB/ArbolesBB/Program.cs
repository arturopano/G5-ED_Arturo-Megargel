using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArbolesBB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario binaryTree = new ArbolBinario();
            string test;
            int value, opcion = 0, n = 0, z= 0;
            bool pass;


            do
            {
                Console.Clear();
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Menu");
                    Console.SetCursorPosition(35, 1);
                    Console.WriteLine("1. Agregar nodo");
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("2. Imprimir arbol");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("3. Buscar nodo");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("4. Eliminar nodo");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("5. Salir");

                    Console.SetCursorPosition(36, 9);
                    Console.WriteLine("¿Qué acción desea realizar?");
                    Console.SetCursorPosition(36, 10);
                    test = Console.ReadLine();

                    if (int.TryParse(test, out value))
                    {
                        opcion = Convert.ToInt32(test);
                        if (opcion > 5 || opcion <= 0)
                        {
                            Console.WriteLine("Esta no es una opción valida. Presione ENTER");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        opcion = -1;
                        Console.WriteLine("Esta no es una opción valida. Presione ENTER");
                        Console.ReadLine();
                    }


                } while (opcion > 7 && opcion <= 0);


                switch (opcion)
                {
                    case 1:
                        //Agregar cabeza
                        do
                        {

                            Console.Clear();
                            Console.SetCursorPosition(35, 1);
                            Console.WriteLine("Escribe 1 numero");
                            Console.SetCursorPosition(35, 2);
                            test = Console.ReadLine();

                            if (int.TryParse(test, out value))
                            {
                                n = Convert.ToInt32(test);

                                binaryTree.Add(n);
                                pass = true;
                            }
                            else
                            {
                                Console.SetCursorPosition(35, 4);
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("PreOrder Traversal:");
                        binaryTree.TraversePreOrder(binaryTree.Root);
                        Console.WriteLine();

                        Console.WriteLine("InOrder Traversal:");
                        binaryTree.TraverseInOrder(binaryTree.Root);
                        Console.WriteLine();

                        Console.WriteLine("PostOrder Traversal:");
                        binaryTree.TraversePostOrder(binaryTree.Root);
                        Console.WriteLine();
                        pass = true;

                        Console.ReadLine();
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.SetCursorPosition(35, 1);
                            Console.WriteLine("Escribe el numero del nodo a buscar");
                            Console.SetCursorPosition(35, 2);
                            test = Console.ReadLine();

                            if (int.TryParse(test, out value))
                            {
                                n = Convert.ToInt32(test);
                                binaryTree.Find(n);
                                Console.Clear();

                                if (binaryTree.finded)
                                {

                                    Console.SetCursorPosition(35, 1);
                                    Console.WriteLine("Nodos recorridos");
                                    Console.SetCursorPosition(35, 3);
                                    for (int i = 0; i < binaryTree.lista.Count; i++)
                                    {
                                        Console.Write(binaryTree.lista[i] + "-");
                                    }
                                    Console.WriteLine(test);
                                }
                                else
                                {
                                    Console.SetCursorPosition(35, 1);
                                    Console.WriteLine("No se encontro el nodo");
                                }
                                Console.ReadLine();
                                pass = true;
                            }
                            else
                            {
                                Console.SetCursorPosition(35, 4);
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);
                        break;

                    case 4:
                        do
                        {

                            Console.Clear();
                            Console.SetCursorPosition(35, 1);
                            Console.WriteLine("Escribe el nodo a eliminar");
                            Console.SetCursorPosition(35, 2);
                            test = Console.ReadLine();

                            if (int.TryParse(test, out value))
                            {
                                n = Convert.ToInt32(test);

                                binaryTree.Remove(n);
                                Console.SetCursorPosition(35, 4);
                                if (binaryTree.finded)
                                {
                                    Console.WriteLine("Nodo eliminado correctamente");
                                }
                                else
                                {
                                    Console.WriteLine("No se encontro el nodo");
                                }
                                Console.ReadLine();
                                    pass = true;
                            }
                            else
                            {
                                Console.SetCursorPosition(35, 4);
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);
                        break;

                    case 5:
                        Console.Clear();
                        Console.SetCursorPosition(35, 1);
                        Console.WriteLine("Saliendo...");
                        Console.SetCursorPosition(35, 2);
                        Console.WriteLine("Presione ENTER");
                        break;
                }
            } while (opcion != 5);

            Console.ReadLine();

          
           


        }
    }
}
