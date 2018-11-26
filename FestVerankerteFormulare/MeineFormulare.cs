using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestVerankerteFormulare
{
    public class MeineFormulare
    {
        public static Form1 Form1Self;
        public static Unterformular UnterformularSelf;
        public static DetailFormular DetailformularSelf;

        static MeineFormulare()
        {
            Form1Self = new Form1();
            UnterformularSelf = new Unterformular();
            DetailformularSelf = new DetailFormular();
        }
    }
}
