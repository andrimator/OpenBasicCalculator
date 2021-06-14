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
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2 + num3;
            Console.WriteLine("");
            Console.WriteLine("Final Operation:\n");

            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + result + "\n");
            Console.WriteLine("Raw Result: " + result);

            Console.ReadLine(); //Lectura final
        }
    }
}
