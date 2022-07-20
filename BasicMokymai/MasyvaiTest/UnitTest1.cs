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

        [TestMethod]
        public void RikiuotiTrisRaides_Test()
        {
            char[] fake = new char[] { 'C', 'D', 'B' };
            char[] expected = new char[] { 'B', 'C', 'D' };
            var actual = P020_Masyvu_Kartojimas.Program.RikiuotiTrisRaides(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RikiuotiKeturiasRaides_Test()
        {
            string[] fake = new string[] { "C", "A", "B", "E" };
            string expected = "A-B-C-E";
            var actual = P020_Masyvu_Kartojimas.Program.RikiuotiKeturiasRaides(fake);
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void DidesnisUzDidziausia2_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = P021_List.Program.DidesnisUzDidziausia2(fake);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}