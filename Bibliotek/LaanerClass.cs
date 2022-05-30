using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class LaanerClass
    {

        public int LaanerNummer { get;}
        public string Navn { get;}

        public LaanerClass(int laanerNummer, string navn)
        {
            LaanerNummer = laanerNummer;
            Navn = navn;
        }
    }

}
