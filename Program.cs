using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Pro Calculator 1.0");
            Console.WriteLine("================================");
            Console.WriteLine("Created by andrimator\n");

            Console.WriteLine("Operation mode: + ");
            //Parametros a calcular
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;

            Console.WriteLine(num1 + "+" + num2 + "=" + result);

            Console.ReadLine(); //Lectura final
        }
    }
}
