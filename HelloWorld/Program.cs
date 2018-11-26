using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Snippet: cw
            Console.WriteLine("Hello World!");

            Console.WriteLine("Bitte gib deinen Namen ein: ");
            //Deklaration und Initialisierung von Variablen
            string name = Console.ReadLine();
            Console.WriteLine("Bitte gib dein Alter ein: ");
            int alter =  int.Parse(Console.ReadLine());

            Console.WriteLine("Bitte gib den Namen der 2. Person ein: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Bitte gib das Alter der 2. Person ein: ");
            int alter2 = int.Parse(Console.ReadLine());

            #region Alte Varianten
            //Console.WriteLine("Herzlich Willkommen " +  name + "!");
            //Console.WriteLine("Herzlich Willkommen {0}!", name);
            #endregion
            //Interpolated Strings
            Console.WriteLine($"Herzlich Willkommen {name} ({alter} Jahre)!");
            Console.WriteLine($"Herzlich Willkommen {name2} ({alter2} Jahre)!");

            //2. Person, Alter + Name eingeben lassen
            //Durchschnittesalter von Anja und Fritz: 15 Jahre

            double durchschnitt = (alter + (double)alter2) / 2;
            Console.WriteLine($"Durchschnittsalter: {durchschnitt}");
            Console.WriteLine($"Durchschnittsalter: {(alter + alter2) / 2}");

            Console.ReadLine();
        }
    }
}