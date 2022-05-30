using Bibliotek;
Console.WriteLine("Indtast navn på bibliotek:");
BibliotekClass bibliotek = new(Console.ReadLine());
Console.WriteLine(bibliotek.HentBibliotek());


Console.WriteLine("Indtast lånernummer:");
int laanerNummer = BibliotekClass.TryParseInt();
Console.WriteLine("Indtast navn på låner:");
string navn = Console.ReadLine();

Console.WriteLine(bibliotek.HentLaaner(bibliotek.OpretLaaner(laanerNummer, navn)));


