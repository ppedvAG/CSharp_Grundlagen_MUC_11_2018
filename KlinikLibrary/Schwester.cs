using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eigene_Klassen;
using KlinikBibo;

namespace KlinikBibliothek
{
    public class Schwester : Mitarbeiter, IBetreuerungsFähig
    {
        public bool IstOberschwester { get; set; } = false;
       

        public Schwester(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum) : base(vorname, nachname, geschlecht, geburtsdatum)
        {
        }

        public override string ToString()
        {
            string oberschwesterString = "ist eine Schwester";
            if(IstOberschwester == true)
            {
                oberschwesterString = "ist eine Oberschwester";
            }
            return base.ToString() + $", {oberschwesterString}";
        }
    }
}
