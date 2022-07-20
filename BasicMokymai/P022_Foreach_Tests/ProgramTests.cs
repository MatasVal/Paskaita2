using Microsoft.VisualStudio.TestTools.UnitTesting;
using P022_Foreach;
using System.Collections.Generic;

namespace P022_Foreach_Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ApskaiciuotiVidurki_Test()
        {
            var fake = new List<double> { 5, 1, 6, 8, 7 };
            var expected = 5.4;
            var actual = P022_Foreach.Program.ApskaiciuotiVidurki(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrintiSkaiciausTeigiamuma_Test()
        {
            var teigiamoTekstas = "Teigiamas";
            var neigiamoTekstas = "Neigiamas";
            var fake = new List<int> { 5, -1, 0, 8, -5 };
            var expected = new List<string> { teigiamoTekstas, neigiamoTekstas, teigiamoTekstas, teigiamoTekstas, neigiamoTekstas };
            var actual = P022_Foreach.Program.TikrintiSkaiciausTeigiamuma(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
        

        [TestMethod]
        public void ApskaiciuotiGPM_Test()
        {
            var gpm = 15;
            var fake = new List<double>()
            {
                100,150,188.88,153.87,68.68
            };
            var expected = 99,2145;
            var actual = P022_Foreach.Program.ApskaiciuotiGPM(fake, gpm);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IstrauktiSkaicius_Test()
        {
            var fake = "sdfg51sd84as21";
            var expected = "518421";
            var actual = Program.IstrauktiSkaicius(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SurikiuotiSkaiciusIsTeksto_Test()
        {
            var fake = "518421";
            var expected = new List<int>() { 1, 1, 2, 4, 5, 8 };
            var actual = Program.SurikiuotiSkaiciusIsTeksto(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IstrauktiSkaiciusIrSurikiuotiSkaiciusIsTeksto_Test()
        {
            var fake = Program.IstrauktiSkaicius("sdfg51sd84as21");
            var expected = new List<int>() { 1, 1, 2, 4, 5, 8 };
            var actual = Program.SurikiuotiSkaiciusIsTeksto(fake);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}