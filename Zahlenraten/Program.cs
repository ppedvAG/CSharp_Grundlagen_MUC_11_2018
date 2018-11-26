using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 zufällige Zahl generieren, und den Nutzer solange raten lassen
            //bis er die erzeugte Zahl erraten hat.
            //Nach jedem Versuch ausgeben ob Zahl zu groß oder zu klein war

            //Baue neuen Zufallsgenerator
            //Möglichst nur 1 Mal im Program bauen
            Random random = new Random();

            //Erzeuge zufällige Zahl zwischen 1 und 10
            int zufallszahl = random.Next(1, 11);

            int anzahlVersuche = 0;
            int gerateneZahl = -1;

            #region Andere Variante
            //bool richtigGeraten = false;

            ////Code innerhalb des Schleifenblocks wird solange wiederholt bis Bedingung false ist
            //while (zufallszahl != gerateneZahl)
            //{
            //    Console.Write("Rate eine Zahl zwischen 1 und 10: ");
            //    gerateneZahl = int.Parse(Console.ReadLine());
            //    anzahlVersuche++;

            //    //if (zufallszahl == gerateneZahl)
            //    //{
            //    //    Console.WriteLine("Du hast die Zahl richtig geraten!");
            //    //    //richtigGeraten = true;
            //    //    //Verlässt die Schleife
            //    //    //break;
            //    //    //continue: springe zum Anfang der Schleife
            //    //}
            //    if (gerateneZahl > zufallszahl)
            //    {
            //        Console.WriteLine("Deine Zahl war zu groß!");
            //    }
            //    //else (gerateneZahl < zufallszahl) 
            //    //{
            //    //    Console.WriteLine("Deine Zahl war zu klein!");
            //    //}
            //}
            #endregion


            do
            {
                Console.Write("Rate eine Zahl zwischen 1 und 10: ");
                gerateneZahl = int.Parse(Console.ReadLine());
                anzahlVersuche++;

                if (zufallszahl == gerateneZahl)
                {
                    Console.WriteLine("Du hast die Zahl richtig geraten!");
                    //Verlässt die Schleife
                    //break;
                    //continue: springe zum Anfang der Schleife
                }
                else if (gerateneZahl > zufallszahl)
                {
                    Console.WriteLine("Deine Zahl war zu groß!");
                }
                else
                {
                    Console.WriteLine("Deine Zahl war zu klein!");
                }

            } while (zufallszahl != gerateneZahl);

            Console.WriteLine("Du hast die Zahl richtig geraten!");

            Console.WriteLine($"Zahl war {zufallszahl}");
            Console.WriteLine($"Du hast {anzahlVersuche} Versuche gebrauchht.");

            Console.ReadLine();
        }
    }
}