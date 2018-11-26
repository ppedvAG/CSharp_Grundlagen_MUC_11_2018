using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        //neuer Datentyp
        enum Rechenoperationen { Add, Subtr, Div, Mult };

        static void Main(string[] args)
        { 

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Beep();

            Console.Write("1. Zahl: ");
            double zahl1 = double.Parse(Console.ReadLine());
            Console.Write("2. Zahl: ");
            double zahl2 = double.Parse(Console.ReadLine());
            char operation = Console.ReadKey().KeyChar;

            double ergebnis = Berechne(zahl1, zahl2, operation);

            Console.WriteLine();
            Console.WriteLine($"Ergebnis: {ergebnis}");

            Console.ReadKey();
        }

        private static double BerechneEnum(double zahl1, double zahl2, Rechenoperationen rechenoperation)
        {
            switch (rechenoperation)
            {
                case Rechenoperationen.Add:
                    return zahl1 + zahl2;
                case Rechenoperationen.Subtr:
                    return zahl1 - zahl2;
                case Rechenoperationen.Div:
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt!");
                        return 0;
                    }
                    return zahl1 / zahl2;
                case Rechenoperationen.Mult:
                    return zahl1 * zahl2;
                default:
                    //Exception
                    return 0;
            }
        }

        private static double Berechne(double zahl1, double zahl2, char rechenoperation)
        {
            if (rechenoperation == '+')
            {
                return zahl1 + zahl2;
            }
            else if (rechenoperation == '/')
            {
                if (zahl2 == 0)
                {
                    Console.WriteLine("Division durch Null ist verboten!!");
                    return 0;
                }
                return zahl1 / zahl2;
            }
            return 0;
        }
    }
}