using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int dias;

            Console.WriteLine($"Por favor, escoge un número del 1 al 7: ");
            dias = int.Parse(Console.ReadLine());

            switch (dias)
            {
                case 1:
                    Console.WriteLine($"LUNES");
                    break;
                case 2:
                    Console.WriteLine($"MARTES");
                    break;
                case 3:
                    Console.WriteLine($"MIÉRCOLES");
                    break;
                case 4:
                    Console.WriteLine($"JUEVES");
                    break;
                case 5:
                    Console.WriteLine($"VIERNES");
                    break;
                case 6:
                    Console.WriteLine($"SÁBADO");
                    break;
                case 7:
                    Console.WriteLine($"DOMINGO");
                    break;
                default:
                    Console.WriteLine($"Error: El rango es del 1 al 7.");
                    break;
            }
        }
    }
}
