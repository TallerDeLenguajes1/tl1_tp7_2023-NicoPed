using System;

using EspacioCalculadora;
internal class Program
{
    static void Main(string[] args)
    {
        int opcion;
        double termino = 0.0;
        string? buffer, auxbuff;
        var calculadora = new Calculadora();
        do
        {
        Console.WriteLine("========================");
        Console.WriteLine("1- Sumar");
        Console.WriteLine("2- Restar");
        Console.WriteLine("3- Multiplicar");
        Console.WriteLine("4- Dividir");
        Console.WriteLine("5- Limpiar");
        Console.WriteLine("0- Salir");
        Console.WriteLine("========================");
        Console.Write("Ingrese una opcion: ");
        buffer = Console.ReadLine();
        auxbuff = buffer;
        if (int.TryParse(buffer, out opcion))
        {
        if (opcion!=0)
        {          
            if (opcion != 5)
            { 
                Console.Write("Ingrese un numero: ");
                buffer = Console.ReadLine();
                
                if (double.TryParse(buffer,out termino))
                {    
                    switch (opcion)
                    {
                        case 1:
                        calculadora.Sumar(termino);
                            break;
                        case 2:
                        calculadora.Restar(termino);
                            break;
                        case 3:
                        calculadora.Multiplicar(termino);
                            break;
                        case 4:
                        calculadora.Dividir(termino);
                            break;
                        case 0:
                            Console.WriteLine("===Saliendo===");
                            break;
                        default:
                            Console.WriteLine("===Ingrese una opcion correcta===");
                            break;
                    }
                }
            }else
            {
                calculadora.Limpiar();
            }
        }    
            Console.WriteLine("=====Res: "+ calculadora.resultado+"=====");
        }
        } while (opcion != 0);
    }
}
