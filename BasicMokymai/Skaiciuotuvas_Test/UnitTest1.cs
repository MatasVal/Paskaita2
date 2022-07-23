using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skaiciuotuvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas_Test
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SkaiciuotuvasTest0()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.CalculatorMenu(move);
            }
            var actual = Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void SkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.Skaiciuotuvas(move);
            }
            var actual = Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            Skaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                Skaiciuotuvas.Program.CalculatorMenu(move);
            }
            var actual = Skaiciuotuvas.Program.CalculatorMenu();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            Skaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
               Skaiciuotuvas.Program.CalculatorMenu(move);
            }
            var actual = Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
    }
}