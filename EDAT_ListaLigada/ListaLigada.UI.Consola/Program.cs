using ListaLigada.Logica;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple \n");

        var singleList = new SingleList<string>();
        int opcion = 0;


        do
        {

            opcion = Menu();
            switch (opcion)
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
                    //default: Console.WriteLine("La opcion no existe");
                    //    break;
            }


        } while (opcion != 0);

        void AgregarElemento()
        {
            Console.WriteLine("* Agregar elementos de la lista *\n");
            Console.WriteLine("Escriba el nombre del nodo:   ");
            var nombre = Console.ReadLine();
            singleList.Add(nombre);
        }

        void MostrarLista()
        {
            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine(singleList);
            }
        }









        Console.ReadKey();

    }// fin de main
    private static int Menu()
    {
        Console.WriteLine("Menu\n");
        Console.WriteLine("1. Agregar elemento\n");
        Console.WriteLine("2. Mostrar Lista\n");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;
        int opcion = 0;

        do
        {
            Console.WriteLine("Seleccione una opcion del menu: ");
            var opcionCapturada = Console.ReadLine();
            Console.WriteLine("");

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingrese una opcion valida\n: ");
                esValido = false;
            }
            else
            {
                esValido = true;
            }

        } while (esValido == false);

        return opcion;
    }
}