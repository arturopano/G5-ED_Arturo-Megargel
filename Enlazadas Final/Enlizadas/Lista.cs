using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enlizadas
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }
        //Aqui se agrega las cantidades y las listas
        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese el dato que contedra el nuevo Nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("\n Nodo Ingresado\n ");
        }
        public void eliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Elegido = false;
            Console.Write("Ingrese el dato del nodo a Buscar para Eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while(Actual != null && Elegido != true)
                {
                    if(Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("El nodo con el dato ( {0} Eonctrado", nodoBuscado);

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if(Actual == Primero)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("Nodo Elimando");

                        Elegido = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if(!Elegido)
                {
                    Console.WriteLine("Nodo no Encontrado");                
                }
            }
        }
        public void desplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while(Actual != null)
                {
                    Console.WriteLine(" {0} ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n Las lista se encuentra vacia\n ");
            }

        }
    }
}
