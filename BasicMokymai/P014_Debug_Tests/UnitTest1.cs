namespace P014_Debug_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Skaiciuotuvas_Test()
        {
            //fake
            var sk1 = 3;
            var sk2 = 2;
            //expected
            var expected = 1.5;
            //actual
            var actual = P014_Debug_Savarankiskos.Program.Skaiciuotuvas(sk1, sk2, "/");


        }

        [TestMethod]
        public void TrikampioPlotas_Test()
        {
            //fake
            var b = 1;
            //expected
            var expected = 1;
            //actual
            var actual = P014_Debug_Savarankiskos.Program.TrikampioPlotas(b, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}