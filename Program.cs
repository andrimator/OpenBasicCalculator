using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveConsoleApp
{
    class globalVariables
    {
        public static int missCount= 0;
        public static int missLimit= 3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            ModeSelect();
        }

        static void Title()
        {
            Console.Title = "Open Basic Calculator v0.3-alpha";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================");
            Console.WriteLine("Open Basic Calculator 0.3-alpha");
            Console.WriteLine("================================");
            Console.WriteLine("Created by andrimator - Made in C#");
        }

        static void ModeSelect()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nSeleccione el modo a utilizar (+, -, *, /) : ");
            string calcMode = Convert.ToString(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            switch(calcMode)
            {
                case "+":
                    Console.WriteLine("\nModo de Suma activada\nFormato: a + b + c (only numbers, otherwise it will crash)");
                    ObtenerVariables("+");
                    break;
                case "-":
                    Console.WriteLine("\nModo de Resta activada\nFormato: a - b - c (only numbers, otherwise it will crash)");
                    ObtenerVariables("-");
                    break;
                case "*":
                    Console.WriteLine("\nModo de Multiplicacion activada\nFormato: a * b * c (only numbers, otherwise it will crash)");
                    ObtenerVariables("*");
                    break;
                case "/":
                    Console.WriteLine("\nModo de Division activada\nFormato: a / b / c (only numbers, otherwise it will crash)");
                    ObtenerVariables("/");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red; //Color Rojo
                    if(globalVariables.missCount >= globalVariables.missLimit) Console.Write("Has insertado un modo no válido!\nEscribe alguno de los caracteres contenidos en los parentesis! () ");
                    else
                    {
                        globalVariables.missCount++;
                        Console.Write("Has insertado un modo no válido!");
                    }
                    ModeSelect();
                    break;
            }
            Console.ReadLine();
        }

        static void ObtenerVariables(string mode)
        {
            //int missCounter;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("a. Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b. Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c. Enter another number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            //Enviar variables a su respectivo operador
            switch(mode)
            {
                case "+":
                    OperatorMode3(num1, num2, num3, "+");
                    break;
                case "-":
                    OperatorMode3(num1, num2, num3, "-");
                    break;
                case "*":
                    OperatorMode3(num1, num2, num3, "*");
                    break;
                case "/":
                    OperatorMode3(num1, num2, num3, "/");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red; //Color Rojo
                    //Console.Write("Invalid character! Try again, but this time with numbers. ");
                    Console.Write("Invalid character! Try again. ");
                    break;
            }
        }

        static void OperatorMode3(double a, double b, double c, string mode)
        {
            double mathResult;
            switch(mode)
            {
                case "+":
                    mathResult = a + b + c;
                    Console.WriteLine("Final Operation:");
                    Console.WriteLine(a + "+" + b + "+" + c + "=" + mathResult);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Raw Result: " + mathResult);
                    break;
                case "-":
                    mathResult = a - b - c;
                    Console.WriteLine("Final Operation:");
                    Console.WriteLine(a + "-" + b + "-" + c + "=" + mathResult);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Raw Result: " + mathResult);
                    break;
                case "*":
                    mathResult = a * b * c;
                    Console.WriteLine("Final Operation:");
                    Console.WriteLine(a + "*" + b + "*" + c + "=" + mathResult);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Raw Result: " + mathResult);
                    break;
                case "/":
                    mathResult = a / b / c;
                    Console.WriteLine("Final Operation:");
                    Console.WriteLine(a + "/" + b + "/" + c + "=" + mathResult);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Raw Result: " + mathResult);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            GivenResult();
        }
        
        static void GivenResult()
        {
            Console.Write("Do you wanna make another math operation? [Y/N]: ");
            string endTask = Console.ReadLine();
            endTask = endTask.ToUpper();
            if(endTask.Contains("Y"))
            {
                globalVariables.missCount = 0;
                Console.Write("Clear previous math? [Y/N]: ");
                string clearLog = Console.ReadLine();
                clearLog = clearLog.ToUpper();
                if(clearLog.Contains("Y"))
                {
                    Console.Clear();
                    Title();
                    ModeSelect();
                }
                else ModeSelect();
            } else System.Environment.Exit(0);
        }
    }
}
