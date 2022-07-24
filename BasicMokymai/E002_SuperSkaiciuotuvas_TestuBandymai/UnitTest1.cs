
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using E002_SuperSkaiciuotuvas_TaikymasTestams;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace E002_SuperSkaiciuotuvas_TestuBandymai.Tests
    {
    [TestClass()]
        public class ProgramTests
        {
            //[TestMethod()]
            //public void SuperSkaiciuotuvasTest1()
            //{
            //    var fake_moves = new string[] { "5", "5" };
            //    var expected = 10;

            //    Program.Reset();
            //    foreach (var move in fake_moves)
            //    {
            //        Program.SuperSkaiciuotuvas(move);
            //    }
            //    var actual = E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Rezultatas();

            //    Assert.AreEqual(expected, actual);
            //}

            //[TestMethod()]
            //public void SuperSkaiciuotuvasTest2()
            //{
            //    var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            //    var expected = 60d;
            //E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Reset();
            //    foreach (var move in fake_moves)
            //    {
            //    E002_SuperSkaiciuotuvas_TaikymasTestams.Program.SuperSkaiciuotuvas(move);
            //    }
            //    var actual = E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Rezultatas();

            //    Assert.AreEqual(expected, actual);
            //}

            //[TestMethod()]
            //public void SuperSkaiciuotuvasTest3()
            //{
            //    var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            //    var expected = 6d;

            //E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Reset();
            //    foreach (var move in fake_moves)
            //    {
            //    E002_SuperSkaiciuotuvas_TaikymasTestams.Program.SuperSkaiciuotuvas(move);
            //    }
            //    var actual = E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Rezultatas();

            //    Assert.AreEqual(expected, actual);
            
            [TestMethod()]
            public void E002_SuperSkaiciuotuvas_TaikymasTestams_Test1()
            {
            var fake_moves = new string[] { "3", "5" };
            var expected = 8d;

            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = E002_SuperSkaiciuotuvas_TaikymasTestams.Program.Result();

            Assert.AreEqual(expected, actual);
            }
    }
}