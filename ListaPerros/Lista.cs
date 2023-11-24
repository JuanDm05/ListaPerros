using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPerros
{
    public class Lista
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public Lista() 
        {
            Primero = null;
            Ultimo = null;
        }
        public void insertar(Perro perro)
        {
            Nodo Nuevo = new Nodo(perro);

            if(Primero == null)
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
            Console.WriteLine("Nodo ingresado");
        }
        public void MostrarPerro()
        {
            Nodo Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine($"El nombre del perro es {Actual.DatosPerro.Nombre} y  su edad es {Actual.DatosPerro.edad}");
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public void buscarPerro(string nombrePerro)
        {
            Nodo Actual = Primero;
            bool encontrado = false;
            if (Primero != null)
            {
                while(Actual != null)
                {
                    if (Actual.DatosPerro.Nombre == nombrePerro)
                    {
                        Console.WriteLine("El perro con el nombre {0} FUE ENCONTRADO" , Actual.DatosPerro.Nombre);
                        encontrado  = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if(!encontrado)
                {
                    Console.WriteLine("Perro no encontrado en esta lista");
                }
            }
            else
            {
                Console.WriteLine("Lista vacia ");
            }


        }
        public void ModificarPerro(int buscarEdad)
        {
            Nodo Actual = Primero;
            bool encontrado = false;    
            if (Primero != null)
            {
                while(Actual !=null)
                {
                    if (Actual.DatosPerro.edad == buscarEdad)
                    {
                        Console.WriteLine("Perro encontrado con edad {0}",buscarEdad);
                        Console.WriteLine("Ingresa el nuevo nombre del perro");
                        string nombrePerro = Console.ReadLine();
                        Console.WriteLine("Ingresa nueva edada de perro");
                        int nuevaEdada = int.Parse(Console.ReadLine());

                        Actual.DatosPerro.edad = nuevaEdada;
                        Actual.DatosPerro.Nombre = nombrePerro;
                        Console.WriteLine("Perro modificado correctamente");
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("Perro no esta en este nodo");
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
            
        }
        public void EliminarPerro(string nombre, int edad)
        {
            Nodo Actual = Primero;
            Nodo Anterior = null;
            bool encontrado = false;
            if (Primero != null)
            {
                while(Actual != null && encontrado != true)
                {
                   if(Actual.DatosPerro.Nombre == nombre && Actual.DatosPerro.edad == edad)
                    {
                        if(Actual == Primero )
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if( Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("Perro eliminado correctamente");
                        encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if(!encontrado)
                {
                    Console.WriteLine("PERRO NO ENCONTRADO");
                }
            }
            else
            {
                Console.WriteLine("LISTA VACIA");
            }

        }
    }
}
