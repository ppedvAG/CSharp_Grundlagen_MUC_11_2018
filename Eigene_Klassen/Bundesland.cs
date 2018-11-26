using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigene_Klassen
{
    class Bundesland
    {

        //Felder

        /// <summary>
        /// Fläche in km² 😲😲
        /// </summary>
        public double Fläche;
        public string Name;
        public int Einwohner;

        public string[] BerühmteFlüsse = new string[2];

        public bool Stadtstaat;

        public List<Bundesland> AngrenzendeLänder = new List<Bundesland>();

        public Bundesland(double fläche, string name, int einwohner)
        {
            Fläche = fläche;
            Name = name;
            Einwohner = einwohner;
        }

        //Methoden

        /// <summary>
        /// Lässt Menschen von einem Bundesland zum anderen abwandern
        /// </summary>
        /// <param name="bundesland">Bundesland in das eingewandert werden soll</param>
        /// <param name="anzahl">Gewünschte Anzahl der Auswanderer</param>
        /// <returns>Anzahl der Personen, die tatsächlich abgewandert sind</returns>
        public int Abwandern(Bundesland bundesland, int anzahl)
        {
            if(anzahl > this.Einwohner)
            {
                Console.WriteLine($"Das geht nicht, so viele Menschen gibt es nicht in {this.Name}");
                return 0;
            }

            bundesland.Einwohner += anzahl;
            this.Einwohner -= anzahl;

            return anzahl;
        }

        public void FügeAlsNachbarlandHinzu(Bundesland nachbarland)
        {
            this.AngrenzendeLänder.Add(nachbarland);
            nachbarland.AngrenzendeLänder.Add(this);
        }
    }
}
