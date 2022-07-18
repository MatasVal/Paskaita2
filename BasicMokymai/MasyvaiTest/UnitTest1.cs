namespace MasyvaiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RastiMaziausia_Test()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, 7, 10 };
            int expected = 3;
            var actual = P020_Masyvu_Kartojimas.Program.RastiMaziausia(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RastiDidziausia_Test()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, 7, 10 };
            int expected = 10;
            var actual = P020_Masyvu_Kartojimas.Program.RastiDidziausia(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SurikiuotiDidejimoTvarka_Test()
        {
            int[] fake = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            int[] expected = new int[] { 1, 5, 6, 7, 7, 8, 10 };
            var actual = P020_Masyvu_Kartojimas.Program.SurikiuotiDidejimoTvarka(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}