using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Methods_Tests
{
    [TestClass]
    public class For_uzduotys_testai
    {
        [TestMethod]
        public static void IntegerToBinary_Test()
        {
            var fake = "45";
            var expected = "101101";
            var actual = P017_ForUzduotys.Program.IntegerToBinary(fake);
            Assert.AreEqual(expected, actual);  
        }
    }
}
