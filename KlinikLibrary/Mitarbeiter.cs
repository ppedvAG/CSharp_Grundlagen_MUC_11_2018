using Eigene_Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikBibliothek
{
    public class Mitarbeiter : Person
    {

        public static int AnzahlMitarbeiter { get; set; } = 0;

        public int Personalnummer { get; private set; }

        private double _gehalt;
        /// <summary>
        /// Gehalt in Euros pro Monat
        /// </summary>
        public double Gehalt
        {
            get { return _gehalt; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Das Gehalt darf nicht negativ sein!");
                }
                _gehalt = value;
            }
        }

        public Mitarbeiter(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum) : base(vorname, nachname, geschlecht, geburtsdatum)
        {
            Mitarbeiter.AnzahlMitarbeiter++;
            Personalnummer = AnzahlMitarbeiter;
        }

        public override string ToString()
        {
            return base.ToString() + $", verdient {Gehalt:00.00} Euro, \t\t Personalnummer: {Personalnummer:00000}";
        }
    }
}
