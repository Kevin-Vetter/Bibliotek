using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Bibliotek
    {
        string _biblioteksNavn = string.Empty;


        internal Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        internal string HentBibliotek()
        {
            return string.Format($"Velkommen til {_biblioteksNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");
        }

        
    }
}
