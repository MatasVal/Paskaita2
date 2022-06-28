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
    }
}