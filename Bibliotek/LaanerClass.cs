using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class LaanerClass : Person
    {

        public int LaanerNummer { get;}

        public LaanerClass(int laanerNummer, string navn, string mail)
        {
            LaanerNummer = laanerNummer;
            Navn = navn;
            Mail = mail;
        }
    }

}
