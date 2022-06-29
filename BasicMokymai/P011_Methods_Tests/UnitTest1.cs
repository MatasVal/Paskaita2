namespace P011_Methods_Tests
{
    [TestClass]
    public class P011_SavarankiskosUzduotys_Test
    {
        [TestMethod]
        public void TarpuKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 2;
            var actual = P011_SavarankiskosUzduotys.Program.TarpuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgis_Test1()
        {
            var fake = " as mokausi ";
            var expected = 10;
            var actual = P011_SavarankiskosUzduotys.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }
       /* [TestMethod]
        public void TekstoIlgis_Test1()
        {
            var fake = " as mokausi ";
            var expected = 10;
            var actual = P011_SavarankiskosUzduotys.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }
       */
        [TestMethod]
        public void ArYraZodisMokausi_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}