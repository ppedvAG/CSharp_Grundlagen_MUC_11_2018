using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eigene_Klassen;
using KlinikBibo;

namespace KlinikBibliothek
{
    public class Arzt : Mitarbeiter, IBetreuerungsFähig
    {
        public enum Disziplinen { Chirurgie, Innere_Medizin, Orthopädie, Onkologie }

        public Disziplinen Disziplin { get; set; }
        public string  Titel { get; set; }

        public Arzt(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum) : base(vorname, nachname, geschlecht, geburtsdatum)
        {
             
        }

        public override string ToString()
        { 
            return base.ToString() + $" ist ein Arzt in der {Disziplin}";
        }
    }
}
