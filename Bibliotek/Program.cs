using Bibliotek;
Console.WriteLine("Indtast navn på bibliotek:");
BibliotekClass bibliotek = new(Console.ReadLine());
Console.WriteLine(bibliotek.HentBibliotek());


Console.WriteLine("Indtast lånernummer:");
int laanerNummer = BibliotekClass.TryParseInt();
Console.WriteLine("Indtast navn på låner:");
string navn = Console.ReadLine();

Console.WriteLine(bibliotek.HentLaaner(bibliotek.OpretLaaner(laanerNummer, navn)));


LaanerClass laaner = new(1,"lucas");
LaanerClass laaner1 = new(2,"elias");
LaanerClass laaner2 = new(3,"thomas");
bibliotek.Laanere.Add(laaner);
bibliotek.Laanere.Add(laaner1);
bibliotek.Laanere.Add(laaner2);