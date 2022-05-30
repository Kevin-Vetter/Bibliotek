using Xunit;
using Bibliotek;


namespace UnitTest_Bibliotek
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kevin", 4)]
        [InlineData("elias", 5)]
        [InlineData("lucas", 6)]
        public void Test1(string navn, int laanerNummer)
        {
            LaanerClass laaner = new(laanerNummer,navn);
            BibliotekClass bibliotek = new("pops");
            string actual = bibliotek.HentLaaner(bibliotek.OpretLaaner(laanerNummer, navn));

            Assert.Equal($"L�nernummer: {laaner.LaanerNummer} - Navn: {laaner.Navn} er l�ner hos: {bibliotek._biblioteksNavn}.", actual);
        }
    }
}