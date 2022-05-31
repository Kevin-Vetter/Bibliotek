using Bibliotek;
Console.Title = "Bibliotek af Kevin Vetter";

BibliotekClass bibliotek = new("pops bib");
LaanerClass laaner = new(1, "lucas", "mail@exam.ple");
LaanerClass laaner1 = new(2, "elias", "mail@exam.ple");
LaanerClass laaner2 = new(3, "thomas", "mail@exam.ple");
bibliotek.Laanere.Add(laaner);
bibliotek.Laanere.Add(laaner1);
bibliotek.Laanere.Add(laaner2);
while (true)
{
    Menu();
}

void Menu()
{
    Console.Clear();
    Console.WriteLine($"------------------\nVælg en af følgende:\nA. Vis bibliotekets navn\nB. Opret låner\nC. Udskriv brugere\nD. Afslut\n------------------\n");
    switch (Console.ReadKey().KeyChar)
    {
        case 'a' or 'A':
            Console.Clear();
            Console.WriteLine(bibliotek.HentBibliotek());
            Thread.Sleep(2000);
            break;
        case 'b' or 'B':
            Console.Clear();
            Console.WriteLine("Indtast lånernummer:");
            int laanerNummer = BibliotekClass.TryParseInt();
            Console.WriteLine("Indtast navn på låner:");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast e-mail til låner:");
            string mail = Console.ReadLine();
            Console.Clear();
            bibliotek.OpretLaaner(laanerNummer, navn, mail);
            Thread.Sleep(2500);
            break;
        case 'c' or 'C':
            Console.Clear();
            for (int i = 0; i < bibliotek.Laanere.Count; i++)
            {
                LaanerClass currentObject = bibliotek.Laanere[i];
                Console.Write($"{i + 1}. ");
                Console.WriteLine($"LånerNummer: {currentObject.LaanerNummer} - Navn: {currentObject.Navn} Mail: {currentObject.Mail}");
            }
            Console.WriteLine("\n--Tryk på en knap for at vende tilbage til menuen--");
            Console.ReadKey();
            break;
        case 'd' or 'D':
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            break;
    }
}