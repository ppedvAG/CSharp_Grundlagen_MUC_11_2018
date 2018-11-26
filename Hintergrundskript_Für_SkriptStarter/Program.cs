using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hintergrundskript_Für_SkriptStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Schritt");
            //warte 1000 Millisekunden
            Thread.Sleep(1000);
            Console.WriteLine("2. Schritt");
            Thread.Sleep(1000);
            Console.WriteLine("Fertig!");
        }
    }
}
