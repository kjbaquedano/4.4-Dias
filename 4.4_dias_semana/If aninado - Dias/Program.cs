using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_aninado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int metodo, dias;

            Console.WriteLine($"Por favor, escoge un número del 1 al 7: ");
            dias = int.Parse(Console.ReadLine());
            if (dias == 1)
            {
                Console.WriteLine($"LUNES");
            }
            else
            {
                if (dias == 2)
                {
                    Console.WriteLine($"MARTES");
                }
                else
                {
                    if (dias == 3)
                    {
                        Console.WriteLine($"MIÉRCOLES");
                    }
                    else
                    {
                        if (dias == 4)
                        {
                            Console.WriteLine($"JUEVES");
                        }
                        else
                        {
                            if (dias == 5)
                            {
                                Console.WriteLine($"VIERNES");
                            }
                            else
                            {
                                if (dias == 6)
                                {
                                    Console.WriteLine($"SÁBADO");
                                }
                                else
                                {
                                    if (dias == 7)
                                    {
                                        Console.WriteLine($"DOMINGO");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error: El rango es del 1 al 7.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
