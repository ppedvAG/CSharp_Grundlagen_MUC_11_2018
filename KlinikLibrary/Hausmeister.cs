using Eigene_Klassen;
using KlinikBibliothek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikBibo
{
    public class Hausmeister : Mitarbeiter
    {
        public Hausmeister(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum) : base(vorname, nachname, geschlecht, geburtsdatum)
        {
        }
    }
}
