using Microsoft.VisualStudio.TestTools.UnitTesting;
using P021_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P021_List_Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DidziausiasSarase_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = Program.DidziausiasSarase(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DidziausiasSarase_SuSort_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = Program.DidziausiasSarase_SuSort(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DidesnisUzDidziausia_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = Program.DidesnisUzDidziausia(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DidesnisUzDidziausia_SuSort_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = Program.DidesnisUzDidziausia_SuSort(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}