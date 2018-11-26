using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eigene_Klassen;
using KlinikBibo;

namespace KlinikBibliothek
{
    public class Patient : Person
    {
        public static int MaxAnzahlÄrzte = 1;
        public static int MAxAnzahlSchwestern = 2;

        public DateTime Aufnahmedatum { get; set; }
        public string ICDCode { get; set; }

        /// <summary>
        /// Jeder Patient darf maximal 2 Schwestern und einen Arzt als Betreuer haben
        /// </summary>
        public List<Mitarbeiter> Betreuer { get; set; }

        public Patient(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum) : base(vorname, nachname, geschlecht, geburtsdatum)
        {
            Betreuer = new List<Mitarbeiter>();
        }
        
        public void FügeBetreuerHinzu(Mitarbeiter mitarbeiter)
        {
            if(Betreuer.Count >= MaxAnzahlÄrzte + MAxAnzahlSchwestern)
            {
                Console.WriteLine("Es gibt schon 3 Betreuer!");
                return;
            }
            if (Betreuer.Contains(mitarbeiter))
            {
                Console.WriteLine("Mitarbeiter ist schon zugewiesen!");
                return;
            }
            int ärzte = 0;
            int schwester = 0;

            foreach (var betreuer in Betreuer)
            {
                //if(betreuer.GetType() == typeof(Arzt))    
                if(betreuer is Arzt)
                {
                    ärzte++;
                }
                else if(betreuer is Schwester)
                {
                    schwester++;
                }
            }
            
            //Wenn hinzuzufügender Mitarbeiter ein Arzt ist und es gibt schon einen Arzt -> Abbruch
            if(mitarbeiter is Arzt && ärzte >= MaxAnzahlÄrzte)
            {
                Console.WriteLine("Es gibt schon einen Arzt!");
                return;
            }
            //Wenn hinzuzufügender Mitarbeiter eine Schweseter ist und es gibt schon 2 Schwestern -> Abbruch
            if(mitarbeiter is Schwester && schwester >= MAxAnzahlSchwestern)
            {
                Console.WriteLine("Es gibt schon 2 Schwestern!");
                return;
            }

            Betreuer.Add(mitarbeiter);
        }

        public override string ToString()
        {
            return base.ToString() + $", Diagnose: {ICDCode}\n" +
                $"{Betreuer.Count} Betreuer, aufgenommen am {Aufnahmedatum.ToShortDateString()}";
        }
    }
}