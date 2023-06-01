using System;
using EspacioCalculadora;
internal class Program
{
    static void Main(string[] args)
    {
        int opcion;
        double termino = 0.0;
        string buffer;
        do
        {
        Console.WriteLine("1- Sumar");
        Console.WriteLine("2- Restar");
        Console.WriteLine("3- Multiplicar");
        Console.WriteLine("4- Dividir");
        Console.WriteLine("5- Limpiar");
        Console.WriteLine("0- Salir");
        Console.Write("Ingrese una opcion: ");
        buffer = Console.ReadLine();
        if (int.TryParce(buffer, out opcion))
        {
            Console.Write("Ingrese un numero: ");
            buffer = Console.ReadLine();
            if (double.TryParce(buffer,out termino))
            {    
                switch (opcion)
                {
                    case 1:
                    
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("===Saliendo===");
                        break;
                }
            }else
            {
                opcion = 6;
            }
        }else
        {
            opcion = 6;
        }
        } while (opcion != 0);
    }
}
