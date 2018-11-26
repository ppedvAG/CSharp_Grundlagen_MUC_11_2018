using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigene_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {

            Person anja = new Person("Anja", "Schulz", Person.Geschlechter.Weiblich, new DateTime(1980,3,20));
            Person moritz = new Person("Moritz", "Bleibtreu", Person.Geschlechter.Männlich, new DateTime(1982,1,1));

            anja.OperiereUm(Person.Geschlechter.Männlich, "Anton");

            anja.Ehepartner = moritz;

            Console.WriteLine(anja.Ehepartner);

            Console.WriteLine(anja.Name);
            Console.WriteLine(anja.Ehepartner.Name);
            Console.WriteLine(anja.Ehepartner.Ehepartner.Name);

            //Bundesland sachsen = new Bundesland(16000, "Sachsen", 2_000_000);
            //sachsen.Name = "Sachsen";
            //sachsen.Einwohner = 2_000_000;
            //sachsen.Stadtstaat = false;


            //Bundesland hamburg = new Bundesland(1000, "Hamburg", 1_000_000);
            //hamburg.Stadtstaat = true;

            //Bundesland sachsenAnhalt = new Bundesland();
            //sachsenAnhalt.Name = "Sachsen-Anhalt";
            //sachsenAnhalt.Einwohner = 1_000_000;

            //sachsenAnhalt.Abwandern(sachsen, sachsenAnhalt.Einwohner);

            //Console.WriteLine($"Einwohner Sachsen: {sachsen.Einwohner}");
            //Console.WriteLine($"Einwohner Sachsen-Anhalt: {sachsenAnhalt.Einwohner}");

            //Sachsen als Nachbarland von Sachsen - Anhalt zu setzen
            //sachsenAnhalt.FügeAlsNachbarlandHinzu(sachsen);

            //Console.WriteLine("Nachbarländer von Sachsen: ");
            //foreach (var bundesland in sachsen.AngrenzendeLänder)
            //{
            //    Console.WriteLine($"{bundesland.Name}");
            //}

            Console.ReadKey();

        }
    }
}
