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
            Console.Title = "Open Basic Calculator v0.1-alpha";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("================================");
            Console.WriteLine("Open Basic Calculator 0.1");
            Console.WriteLine("================================");
            Console.WriteLine("Created by andrimator\n");

            ModeSelect();
        }

        static void ModeSelect()
        {
            Console.Write("Seleccione el modo a utilizar (+, -, *, /) : ");
            string calcMode = Convert.ToString(Console.ReadLine());
            switch(calcMode)
            {
                case "+":
                    ActivateSumaMode();
                    break;
                case "-":
                    ActivateRestaMode();
                    break;
                case "*":
                    ActivateMultiMode();
                    break;
                case "/":
                    ActivateDivMode();
                    break;
                default:
                    ModeSelectError();
                    break;
            }
            Console.ReadLine();
        }

        static void ModeSelectError()
        {
            Console.ForegroundColor = ConsoleColor.Red; //Color Rojo
            Console.Write("Has insertado un modo no válido! Selecciona el modo a utilizar (+, -, *, /) : ");
            string calcMode = Convert.ToString(Console.ReadLine());
            switch(calcMode)
            {
                case "+":
                    ActivateSumaMode();
                    break;
                case "-":
                    ActivateRestaMode();
                    break;
                case "*":
                    ActivateMultiMode();
                    break;
                case "/":
                    ActivateDivMode();
                    break;
                default:
                    ModeSelectError();
                    break;
            }
        }

        static void ActivateSumaMode()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[INFO] Modo de Suma activada\nFormato: a + b + c (only numbers)");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            SumadorMode3(num1, num2, num3);
        }

        static void SumadorMode3(double sa, double sb, double sc)
        {
            double sr = sa + sb + sc;
            Console.WriteLine("Final Operation:");
            Console.WriteLine(sa + "+" + sb + "+" + sc + "=" + sr);
            Console.WriteLine("Raw Result: " + sr);
            Console.WriteLine("");
            GivenResult();
        }
        
        static void ActivateRestaMode()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[INFO] Modo de Resta activada\nFormato: a - b - c");
            Console.Write("Enter a number: ");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum3 = Convert.ToDouble(Console.ReadLine());
            RestadorMode3(sum1, sum2, sum3);
        }

        static void RestadorMode3(double sa, double sb, double sc)
        {
            double sr = sa - sb - sc;
            Console.WriteLine("Final Operation:");
            Console.WriteLine(sa + "-" + sb + "-" + sc + "=" + sr);
            Console.WriteLine("Raw Result: " + sr);
            Console.WriteLine("");
            GivenResult();
        }

        static void ActivateMultiMode()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[INFO] Modo de Multiplicacion activada\nFormato: a x b x c");
            Console.Write("Enter a number: ");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum3 = Convert.ToDouble(Console.ReadLine());
            MultiplicatorMode3(sum1, sum2, sum3);
        }

        static void MultiplicatorMode3(double sa, double sb, double sc)
        {
            double sr = sa * sb * sc;
            Console.WriteLine("Final Operation:");
            Console.WriteLine(sa + "x" + sb + "x" + sc + "=" + sr);
            Console.WriteLine("Raw Result: " + sr);
            Console.WriteLine("");
            GivenResult();
        }
        static void ActivateDivMode()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[INFO] Modo de Division activada\nFormato: a / b / c");
            Console.Write("Enter a number: ");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double sum3 = Convert.ToDouble(Console.ReadLine());
            DividendoMode3(sum1, sum2, sum3);
        }

        static void DividendoMode3(double sa, double sb, double sc)
        {
            double sr = sa / sb / sc;
            Console.WriteLine("Final Operation:");
            Console.WriteLine(sa + "/" + sb + "/" + sc + "=" + sr);
            Console.WriteLine("Raw Result: " + sr);
            Console.WriteLine("");
            GivenResult();
        }
        static void GivenResult()
        {
            Console.Write("Do you wanna make another math operation? [Y/N]: ");
            string endTask = Console.ReadLine();
            endTask = endTask.ToUpper();
            endTask = Convert.ToString(endTask);
            if(endTask.Contains("Y")) ModeSelect(); else System.Environment.Exit(0);
        }
    }
}
