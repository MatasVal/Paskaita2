using Microsoft.VisualStudio.TestTools.UnitTesting;
using P022_Foreach;
using System.Collections.Generic;

namespace P022_Foreach_Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod()]
        public void ApskaiciuotiVidurki_Test()
        {
            var fake = new List<double> { 5, 1, 6, 8, 7 };
            var expected = 5.4;
            var actual = Program.ApskaiciuotiVidurki(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TikrintiSkaiciausTeigiamuma_Test()
        {
            var teigiamoTekstas = "Teigiamas";
            var neigiamoTekstas = "Neigiamas";
            var fake = new List<int> { 5, -1, 0, 8, -5 };
            var expected = new List<string> { teigiamoTekstas, neigiamoTekstas, teigiamoTekstas, teigiamoTekstas, neigiamoTekstas };
            var actual = Program.TikrintiSkaiciausTeigiamuma(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ApskaiciuotiGPM_Test()
        {
            var gpm = 15;
            var fake = new List<double>()
            {
                100,150,188.88,153.87,68.68
            };
            var expected = 99.2145;
            var actual = Program.ApskaiciuotiGPM(fake, gpm);

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

        [TestMethod()]
        public void IstrauktiZodzius_Test()
        {
            var fake = "Labas as esu Kodelskis";
            var expected = new string[]
            {
                "Labas",
                "as",
                "esu",
                "Kodelskis"
            };
            var actual = Program.IstrauktiZodzius(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsgautiIlgusZodzius_Test()
        {
            var fake = new string[]
            {
                "Labas",
                "as",
                "esu",
                "Kodelskis"
            };
            var expected = new List<string>
            {
                "Labas",
                "Kodelskis"
            };
            var actual = Program.IsgautiIlgusZodzius(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsvalytiIlgusZodzius_Test()
        {
            var fake = new string[]
            {
                "Labas",
                "as",
                "esu",
                "Kodelskis"
            };
            var expected = new List<string>
            {
                "as",
                "esu"
            };
            var actual = Program.IsvalytiIlgusZodzius(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SurikiuotiZodzius_Test()
        {
            var fake = new List<string>
            {
                "Labas",
                "as",
                "esu",
                "Kodelskis"
            };
            var expected = new List<string>
            {
                "as",
                "esu",
                "Kodelskis",
                "Labas"
            };
            var actual = Program.SurikiuotiZodzius(fake);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SujungtiSarasusZodziu_Test()
        {
            var fake1 = new List<string>
            {
                "Labas",
                "as"
            };
            var fake2 = new List<string>
            {
                "esu",
                "Kodelskis"
            };
            var expected = new List<string>
            {
                "Labas",
                "as",
                "esu",
                "Kodelskis"
            };
            var actual = Program.SujungtiSarasusZodziu(fake1, fake2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsmetytiZodzius_Test()
        {
            var fake = "Labas as esu Kodelskis";
            var expected = new string[]
            {
                "as",
                "esu",
                "Kodelskis",
                "Labas"
            };
            var actual = Program.IsmetytiZodzius(fake);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}