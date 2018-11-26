using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        /// <summary>
        /// Anzahl an zu ziehenden Zahlen
        /// </summary>
        const int anzahlZahlen = 6;

        /// <summary>
        /// Bis zu welcher Zahl soll gezogenen werden
        /// </summary>
        const int wertebereich = 49;

        static void Main(string[] args)
        {
            //Dieses Programm erzeugt zufällig eine bestimmte Anzahl an Zahlen,
            //die der Nutzer erraten muss.

           
            Random random = new Random();

            //Lotto
            int[] gerateneZahlen = new int[anzahlZahlen];
            int[] gezogenenZahlen = new int[anzahlZahlen];

            //1. Schritt: Zufällige Zahlen generieren (Ziehen)
            //i ist die Zählervariable und wird in jedem Schleifendurchlauf um 1 erhöht
            for (int i = 0; i < gezogenenZahlen.Length; i++)
            {
                //TODO: Sicherstellen dass keine Zahl doppelt gezogen wird!
                int neueZahl;

                do
                {
                    neueZahl = random.Next(1, wertebereich + 1);
                } while (gezogenenZahlen.Contains(neueZahl) == true);
                
                gezogenenZahlen[i] = neueZahl;
            }

            //2. Schritt: geratene Zahlen einlesen
            for (int i = 0; i < gerateneZahlen.Length; i++)
            {
                Console.Write($"Tippe deine {i+1}. Zahl: ");
                gerateneZahlen[i] = int.Parse(Console.ReadLine());
            }

            //3. Schritt: Auswertung
            int treffer = 0;
            for (int i = 0; i < gezogenenZahlen.Length; i++)
            {

                DateTime gdatum = new DateTime(2012, 2, 2);

                Console.WriteLine($"{i+1}. Zahl war {gezogenenZahlen[i]}");
                if(gerateneZahlen.Contains(gezogenenZahlen[i]))
                {
                    treffer++;
                }
            }

            Console.WriteLine($"Du hattest {treffer} Treffer!");

            Console.ReadLine();
        }
    }
}