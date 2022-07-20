﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P022_Foreach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Foreach!");
            var rezultatas = IstrauktiSkaicius("1sd512sd5");

        }

        private static void PavyzdiniaiForEachKvietimai()
        {
            int[] taskuMasyvas = new int[10];
            taskuMasyvas[0] = 1;
            foreach (int taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} - naujas elementas");
            }

            string[] masinos = new string[] { "BMW", "Audi", "Toyota" };

            foreach (var masina in masinos)
            {
                Console.WriteLine($"{masina}");
            }

            List<int> amziai = new List<int> { 19, 20, 21 };

            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius: {amzius}");
            }

            var vardai = new List<string> { "Ieva", "Vardenis", "Edgaras" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"vardas: {vardas}");
            }

            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius: {amzius + 5}");
            }

            foreach (var vardas in vardai)
            {
                Console.WriteLine($"vardas: {vardas}");

                foreach (var amzius in amziai)
                {
                    Console.WriteLine($"vardas ir amzius: {vardas} {amzius + 5}");
                }

            }

            foreach (var vardas in vardai)
            {
                if (vardas == "Vardenis")  //ciklo pabaigimas ties vardeniu, vardenio neatspausdina
                    break;
                Console.WriteLine($"vardas: {vardas}");
            }




            string sakinys = "Buvo karta erdve ir ji kazkur paklydo";

            foreach (var raide in sakinys)
            {
                if (raide == 'd')        //string kolekcija yra char masyvas - viengubos kabutes
                    break;
                Console.WriteLine(raide);
            }

            var spalvos = new List<string>();

            spalvos.Add("Melyna");
            spalvos.Add("Zalia");
            spalvos.Add("Geltona");

            foreach (var spalva in spalvos)
            {
                Console.WriteLine($"Spalva: {spalva}");
            }
        }

        //KLASES DARBAS 1. ## Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki.
        public static void PirmasKlasesUzdavinys()
        {
            List<double> skaiciai = new List<double>()
            {
                1, 5, 8, 9, 8, 5
            };

            var rezultatas = ApskaiciuotiVidurki(skaiciai);
            Console.WriteLine($"Pirmo uzdavinio rezultatas : {rezultatas}");
        }
        public static double ApskaiciuotiVidurki(List<double> skaiciai)
        {
            var vidurkis = 0d;

            foreach (var skaicius in skaiciai)
            {
                
                vidurkis += skaicius;
                Console.WriteLine($"Skaicius: {skaicius}. Suma: {vidurkis}");
            }
            return vidurkis/ skaiciai.Count;
        }



        //KLASES DARBAS 2. ## Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve.
        public static void AntrasKlasesUzdavinys()
        {
            List<int> skaiciai = new List<int>()
            {
                1, 5, -8, 9, 0, 8, -5
            };

            List<string> rezultatas = TikrintiSkaiciausTeigiamuma(skaiciai);

            foreach (string skaiciausTeigiamumas in rezultatas)
            {
                Console.WriteLine($"Ar skaicius teigiamas: {skaiciausTeigiamumas}");
            }
            
        }


        public static List<string> TikrintiSkaiciausTeigiamuma(List<int> skaiciai)
        {
            var skaiciuTeigiamumas = new List<string>();

            foreach (var skaicius in skaiciai)
            {
                if (skaicius >= 0)
                    skaiciuTeigiamumas.Add("Teigiamas");
                else
                    skaiciuTeigiamumas.Add("Neigiamas");
            }
            return skaiciuTeigiamumas;
        }


        //KLASES DARBAS 3. ## Parasykite metoda, kuris apskaiciuos kiek jums reikes sumoketi GPM nuo duoto imoku saraso. Sio uzdavinio GPM: 15%

        public static void TreciasKlasesUzdavinys()
        {
            int gpm = 15;
            List<double> imokos = new List<double>()
            {
                100,150,188.88,153.87,68.68
            };

            var rezultatas = ApskaiciuotiGPM(imokos, gpm);
            Console.WriteLine($"GPM: {rezultatas}");
        }


        public static double ApskaiciuotiGPM(List<double> imokos, int gpm)
        {
            var galutinisMokestis = 0d;

            foreach (var imoka in imokos)
            {
                galutinisMokestis += imoka;
            }
            return galutinisMokestis * (gpm/100d);
        }

        /// 4 UZDUOTIS
        ///  Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.
        ///  Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius
        ///  didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:
        ///  PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255

        public static string IstrauktiSkaicius(string tekstas)
        {
            var skaiciaiTekste = new StringBuilder();

            foreach (var simbolis in tekstas)
            {
                if (char.IsDigit(simbolis))
                    skaiciaiTekste.Append(simbolis);
            }

            return skaiciaiTekste.ToString();
        }

        public static List<int> SurikiuotiSkaiciusIsTeksto(string skaiciaiTekste)
        {
            var skaiciai = new List<int>();

            foreach (var skaicius in skaiciaiTekste)
            {
                skaiciai.Add(SkaiciausTikrinimas(skaicius.ToString()));
            }

            skaiciai.Sort();

            return skaiciai;
        }

        public static void AtspausdintiSkaicius(List<int> skaiciai)
        {
            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius.ToString());
            }
        }

        #region PERPANAUDOJAMI METODAI
        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;
        #endregion

        /// <summary>
        ///  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni  arba lygus 5 raidems ir yra surikiuoti abeceles tvarka.
        ///  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.
        ///  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')
        ///  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti". 
        ///  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
        ///  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti
        /// </summary>
    }
}