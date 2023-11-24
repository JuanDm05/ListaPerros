using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPerros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista listaPerros = new Lista();

            int opcion = 0;
            do
            {
                Console.WriteLine("1. Insertar perro");
                Console.WriteLine("2. Mostrar lista de perros");
                Console.WriteLine("3. Editar perro buscandolo por Edada");
                Console.WriteLine("4. Encontrar perro");
                Console.WriteLine("5. Eliminar perro");
                Console.WriteLine("Ingrese la opción:");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese nombre del perro:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese edad del perro:");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Perro nuevoPerro = new Perro { Nombre = nombre, edad = edad };
                        listaPerros.insertar(nuevoPerro);
                        break;
                        case 2:
                        listaPerros.MostrarPerro();
                        break;
                        case 3:
                        Console.WriteLine("Ingresa la edad para buscar");
                        int edadPerro = Convert.ToInt32(Console.ReadLine());
                        listaPerros.ModificarPerro(edadPerro);
                        break;
                    case 4:
                        Console.WriteLine("Ingresa el nombre del perro");
                        string nombreDelCan = Console.ReadLine();
                        listaPerros.buscarPerro(nombreDelCan);
                        break;
                        case 5:
                        Console.WriteLine("Ingresa Nombre y edad del perro para eliminarlo");
                        string NombreP = Console.ReadLine();
                        int edadP = Convert.ToInt32(Console.ReadLine());
                        listaPerros.EliminarPerro(NombreP, edadP);
                        break;

                }
            }while (opcion != 6);
    Console.ReadLine();
        }

    }
}
