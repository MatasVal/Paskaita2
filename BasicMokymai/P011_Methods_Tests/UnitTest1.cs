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

        [TestMethod]
        public void TekstoIlgis_Test1()
        {
            var fake = " as mokausi ";
            var expected = 10;
            var actual = P011_SavarankiskosUzduotys.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }
        // 6 Uzduotis
        [TestMethod]
        public void ZodziuKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P011_SavarankiskosUzduotys.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        // 7 Uzduotis
        [TestMethod]
        public void TarpuKiekisGale_Test1()
        {
            var fake = " as mokausi      ";
            var expected = 6;
            var actual = P011_SavarankiskosUzduotys.Program.TarpuKiekisGale(fake);
            Assert.AreEqual(expected, actual);
        }
        // 8 Uzduotis
        [TestMethod]
        public void TarpuKiekisPradzioje_Test1()
        {
            var fake = " as mokausi      ";
            var expected = 1;
            var actual = P011_SavarankiskosUzduotys.Program.TarpuKiekisPradzioje(fake);
            Assert.AreEqual(expected, actual);
        }
        // 9 Uzduotis
        [TestMethod]
        public void TarpuKiekisPradziojeIrGale_Test1()
        {
            var fake = " as mokausi      ";
            var expectedPriekyje = 1;
            var expectedGale = 6;
            P011_SavarankiskosUzduotys.Program.TarpuKiekisPradziojeIrGale(fake, out int actualPriekyje,out int actualGale);
            Assert.AreEqual(expectedPriekyje, actualPriekyje);
            Assert.AreEqual(expectedGale, actualGale);
        }
        // 10 Uzduotis
        [TestMethod]
        public void KiekYraRaidziuA_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P011_SavarankiskosUzduotys.Program.KiekYraRaidziuA(fake);
            Assert.AreEqual(expected, actual);
        }
        // 11 Uzduotis
        [TestMethod]
        public void ArYraZodisMokausi_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        
        // 11A Uzduotis
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test0()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test1()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Ne";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }


        //Pvz2: 
        //> Iveskite teksta:
        //_ 'aslabaimokausiprogramuoti'
        //> Ar yra mokausi: Ne

        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "Ne";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        // Pvz3: 
        //> Iveskite teksta:
        //_ 'mokausi programuoti labai    '
        //> Ar yra mokausi: Taip
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test3()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        //Pvz4: 
        //> Iveskite teksta:
        // _ 'as mokausi, labai stipriai'
        //> Ar yra mokausi: Taip
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        //Pvz5: 
        //> Iveskite teksta:
        // _ 'as mokausi!'
        //> Ar yra mokausi: Taip
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test5()
        {
            var fake = "as mokausi!";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        //Pvz6: 
        //> Iveskite teksta:
        //_ 'as mokausi?'
        //> Ar yra mokausi: Taip
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test6()
        {
            var fake = "as mokausi?";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        //Pvz7: 
        //> Iveskite teksta:
        //_ 'as studijuoju (mokausi)'
        //> Ar yra mokausi: Taip
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
        //Pvz8: 
        //> Iveskite teksta:
        //_ 'as studijuojumokausi)'
        //> Ar yra mokausi: Ne
        [TestMethod]
        public void ArYraZodisMokausiNesulipes_Test8()
        {
            var fake = "as studijuojumokausi)";
            var expected = "Ne";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausiNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }




        /*
        // 12 Uzduotis


        [TestMethod]
        public void ArYraZodisMokausi_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P011_SavarankiskosUzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        
        }


        [TestMethod]
        public void TekstoIlgisBeTarpu_Test()
        {
            var fake = " as mokausi      ";
            var expected = 10;
            var actual = P010_Methods.Program.TekstoIlgisBeTarpu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgisBeTarpu_Test1()
        {
            var fake = " as  mokausi      ";
            var expected = 11;
            var actual = P010_Methods.Program.TekstoIlgisBeTarpu(fake);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TarpuGaleKiekis_Test()
        {
            var fake = " as mokausi      ";
            var expected = 6;
            var actual = P010_Methods.Program.TarpuGaleKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpuPriekyjeKiekis_Test()
        {
            var fake = " as mokausi      ";
            var expected = 1;
            var actual = P010_Methods.Program.TarpuPriekyjeKiekis(fake);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void KiekYraZodziu_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraZodziu_Test2()
        {
            var fake = "as mokausi programuoti       ";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraZodziu_Test3()
        {
            var fake = "as mokausi      programuoti       ";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraTarpuPriekyjeIrGale()
        {
            var fake = " as mokausi      ";
            var expectedPriekyje = 1;
            var expectedGale = 6;

            P010_Methods.Program.KiekYraTarpuPriekyjeIrGale(
                fake,
                out int actualPriekyje,
                out int actualGale);

            Assert.AreEqual(expectedPriekyje, actualPriekyje);
            Assert.AreEqual(expectedGale, actualGale);
            
        }


        [TestMethod]
        public void KiekYraRaidziuA_Test()
        {
            var fake = "as mokausi A programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraRaidziuA(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_Test()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P010_Methods.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_Test1()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Taip";
            var actual = P010_Methods.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_Test2()
        {
            var fake = " as_labai_MOKAUSI_programuoti     ";
            var expected = "Taip";
            var actual = P010_Methods.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ArYraNesulipesZodisMokausi_Test()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Ne";
            var actual = P010_Methods.Program.ArYraNesulipesZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraNesulipesZodisMokausi_Test1()
        {
            var fake = "mokausi programuoti labai         ";
            var expected = "Taip";
            var actual = P010_Methods.Program.ArYraNesulipesZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ArYraNesulipesZodisMokausi_Test2()
        {
            var fake = "";
            var expected = "Ne";
            var actual = P010_Methods.Program.ArYraNesulipesZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        */


    }
}