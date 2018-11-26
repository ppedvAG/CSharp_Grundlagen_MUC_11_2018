using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigene_Klassen
{
    public class Person
    {

        public enum Geschlechter { Männlich, Weiblich, Sonstiges }

        //Snippet: prop Tab Tab
        public string Vorname { get; private set; }
        public string Nachname { get; set; }
        public Geschlechter Geschlecht { get; private set; }
        //Kurzschreibweise, mit automatisch generierten privaten Feld
        public DateTime Geburtsdatum { get; private set; }
        public int Alter
        {
            get
            {
                return DateTime.Today.Year - Geburtsdatum.Year;
            }
        }
        public string Name
        {
            get
            {
                return $"{Vorname} {Nachname}";
            }
        }


        //private string _passwort;
        //public string Passwort
        //{
        //    set
        //    {
        //        _passwort = value;
        //    }
        //}

        private Person _ehepartner = null;
        public Person Ehepartner
        {
            //Strg+K+D: Formatierung
            get
            {
                return _ehepartner;
            }
            set
            {
                if (value == null)
                    return;

                //Personen müssen unverheiratet sein
                if (_ehepartner != null || value._ehepartner != null)
                {
                    Console.WriteLine("Personen müssen unverheiratet sein!");
                    return;
                }
                if(Alter < 18 || value.Alter < 18)
                {
                    Console.WriteLine("Personen müssen volljährig sein!");
                    return;
                }
                if(value == this)
                {
                    Console.WriteLine("Selbst-Heirat ist verboten!");
                    return;
                }


                //value steht für den Wert, der zugewiesen wurde
                this._ehepartner = value;
                value._ehepartner = this;
                //gleicher Nachname
                value.Nachname = this.Nachname;
            }
        }


        public Person(string vorname, string nachname, Geschlechter geschlecht, DateTime geburtsdatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geschlecht = geschlecht;
            Geburtsdatum = geburtsdatum;
        }

        public Geschlechter OperiereUm(Geschlechter zielGeschlecht, string neuerVorname)
        {
            this.Geschlecht = zielGeschlecht;
            this.Vorname = neuerVorname;
            return zielGeschlecht;
        }

        public override string ToString()
        {
            return $"{Name}, ({Alter} Jahre)";
        }     
    }
}
