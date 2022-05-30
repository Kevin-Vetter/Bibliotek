﻿using Bibliotek;
BibliotekClass bibliotek = new("pops bib");
while (true)
{
    Console.Clear();
loop:
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
            Console.Clear();
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
                Console.WriteLine($"{i + 1}. ");
                Console.Write(bibliotek.Laanere[i].Navn);
            }
            break;
        case 'd' or 'D':
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            goto loop;
    }
}



LaanerClass laaner = new(1, "lucas", "mail@exam.ple");
LaanerClass laaner1 = new(2, "elias", "mail@exam.ple");
LaanerClass laaner2 = new(3, "thomas", "mail@exam.ple");
bibliotek.Laanere.Add(laaner);
bibliotek.Laanere.Add(laaner1);
bibliotek.Laanere.Add(laaner2);