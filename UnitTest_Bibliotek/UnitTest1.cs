using Xunit;
using Bibliotek;


namespace UnitTest_Bibliotek
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kevin", 4, "mail@exam.ple")]
        [InlineData("elias", 5, "mail@exam.ple")]
        [InlineData("lucas", 6, "mail@exam.ple")]
        public void Test1(string navn, int laanerNummer, string mail)
        {
            LaanerClass laaner = new(laanerNummer, navn, mail);
            BibliotekClass bibliotek = new("pops");
            string actual = bibliotek.HentLaaner(bibliotek.OpretLaaner(laanerNummer, navn, mail));

            Assert.Equal($"Lånernummer: {laaner.LaanerNummer} - Navn: {laaner.Navn} er låner hos: {bibliotek._biblioteksNavn}. Kontakt på mail: {laaner.Mail}.", actual);
        }
    }
}