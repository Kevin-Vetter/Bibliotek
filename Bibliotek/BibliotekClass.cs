namespace Bibliotek
{
    public class BibliotekClass
    {
        public string _biblioteksNavn = string.Empty;
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
        }

        public string HentBibliotek()
        {
            return string.Format($"Velkommen til {_biblioteksNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");
        }

        public LaanerClass OpretLaaner(int laanerNummer, string navn)
        {
            return new LaanerClass(laanerNummer, navn);
        }

        public string HentLaaner(LaanerClass laaner)
        {
            return $"Lånernummer: {laaner.LaanerNummer} - Navn: {laaner.Navn} er låner hos: {_biblioteksNavn}.";
        }
    }
}
