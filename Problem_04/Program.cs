using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroLimite;

            Console.Write("Ingrese el número límite: ");
            numeroLimite = int.Parse(Console.ReadLine());

            Console.WriteLine("============================");
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");
            Console.Write("-> ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Números pares:");
                    for (int i = 2; i <= numeroLimite; i += 2)
                    {
                        Console.Write(i + ", ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Números impares:");
                    for (int i = 1; i <= numeroLimite; i += 2)
                    {
                        Console.Write(i + ", ");
                    }
                    break;
                case 3:
                    
                    long factorial = 1;
                    for (int i = 1; i <= numeroLimite; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("El factorial es " + factorial);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
