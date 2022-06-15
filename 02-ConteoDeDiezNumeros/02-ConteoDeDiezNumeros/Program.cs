using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_ConteoDeDiezNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, b, c;

            b = 0;
            c = 0;

            Console.WriteLine("Introducir 10 numeros: ");

            for (i = 1; i <= 10; i++) //No se debe ingresar cero, ya que contara como un onceavo valor
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (a > 0)
                {
                    b = b + 1;

                }
                if (a < 0)
                {
                    c = c + 1;

                }

            }
            Console.WriteLine("Los numeros mayores a cero son: " + b);
            Console.WriteLine("Los numeros menores a cero son: " + c);

            Console.ReadKey();
        }
    }
}
