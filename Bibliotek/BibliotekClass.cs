namespace Bibliotek
{
    public class BibliotekClass
    {
        public string _biblioteksNavn = string.Empty;
        public List<LaanerClass> Laanere;


        static public int TryParseInt()
        {
            int _value;
            while (!int.TryParse(Console.ReadLine(), out _value))
            {
                Console.Clear();
                Console.WriteLine("Ugyldig værdi!");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Indtast et tal: ");
            }
            return _value;
        }

        public BibliotekClass(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
            Laanere = new();
        }

        public string HentBibliotek()
        {
            return string.Format($"Velkommen til {_biblioteksNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");
        }

        public LaanerClass OpretLaaner(int laanerNummer, string navn, string mail)
        {
            LaanerClass laaner = new LaanerClass(laanerNummer, navn, mail);
            Laanere.Add(laaner);
            Console.WriteLine($"Der er nu oprettet en låner med lånernummer {laanerNummer} ved navn {navn} Kontakt på {mail}.");
            return laaner;
        }

        public string HentLaaner(LaanerClass laaner) 
        {
            return $"Lånernummer: {laaner.LaanerNummer} - Navn: {laaner.Navn} er låner hos: {_biblioteksNavn}. Kontakt på mail: {laaner.Mail}.";
        }

        public string HentAlleLaanere()
        {
            string navn = string.Empty;
            foreach (LaanerClass laaner in Laanere)
            {
              navn = navn + laaner.Navn + "\n";
            }
            return navn;
        }
    }
}
