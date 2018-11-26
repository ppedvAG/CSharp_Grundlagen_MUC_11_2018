using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Konverter_Auf_DB_Basis
{
    /// <summary>
    /// Patientenklasse, welche das neue XML-Format mit
    /// Angabe des Aufenthaltortes abbildet.
    /// </summary>
    public class PatientNeu
    {
        public string Name { get; set; }
        public DateTime Geburststag { get; set; }
        public string Aufenthaltsort { get; set; } = "Unbekannt";
    }

    /// <summary>
    /// Patientenklasse, welche das alte XML-Format ohne 
    /// Angabe des Aufenthaltortes abbildet.
    /// </summary>
    public class PatientAlt
    {
        public string Name { get; set; }
        public DateTime Geburststag { get; set; }
    }
}
