using KlinikBibliothek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eigene_Klassen;

namespace KMMUC
{
    public class PersonenManager
    {
        public static BindingList<Patient>  Patienten { get; set; }
        public static BindingList<Arzt>  Ärzte { get; set; }
        public static BindingList<Schwester>  Schwestern { get; set; }

        static PersonenManager()
        {
            Patienten = new BindingList<Patient>();
            Ärzte = new BindingList<Arzt>();
            Schwestern = new BindingList<Schwester>();

            GeneriereTestDaten();
        }

        private static void GeneriereTestDaten()
        {
            Patient patient = new Patient("Max", "Mustermann", Person.Geschlechter.Männlich , new DateTime(1980,1,1));
            patient.ICDCode = "A-6";
            Arzt arzt = new Arzt("Philipp", "Brentano", Person.Geschlechter.Männlich, new DateTime(1985,1,1));
            arzt.Disziplin = Arzt.Disziplinen.Onkologie;
            arzt.Gehalt = 2000;

            Schwester schwester = new Schwester("Ulrike", "Bluhm", Person.Geschlechter.Weiblich, new DateTime(1970,1,1));
            schwester.IstOberschwester = true;

            //Zu Listen hinzufügen
            Patienten.Add(patient);
            Ärzte.Add(arzt);
            Schwestern.Add(schwester);
        }
    }
}
