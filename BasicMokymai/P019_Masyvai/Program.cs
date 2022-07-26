using System;
using System.Text;

namespace P019_Masyvai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Masyvai!");

            // Galime isvengti bereikalingo kintamuju kurimo naudodami masyvus
            int skaicius1 = 100;
            int skaicius2 = 95;
            int skaicius3 = 92;
            // Iki 10 skaiciu

            //deklaravimas
            int[] skaiciai = { 100, 95, 92 };

            //Tuscio masyvo deklaravimas
            int[] skaiciai2 = null;

            if (skaicius1 != skaicius2)
            {
                skaiciai2 = new int[7];
            }

            Console.WriteLine(skaiciai2[1]);

            //vietos isskyrima
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];
            double[] realusSkaiciai = new double[3];

            //reiksmiu irasymas
            skaiciai3[0] = 100;
            skaiciai3[1] = 95;
            skaiciai3[2] = 92;
            //skaiciai3[99] = 999;

            //Daugiau budu masyvu reiksmems deklaruoti
            int[] intMasyvas1 = new int[] { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas2 = new[] { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas3 = new int[1] { 100 };
            int[] intMasyvas4 = { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };

            //Masyvo reikmes gauti pagal indeksa
            Console.WriteLine(intMasyvas1[8]);

            var pazymiai = new int[10];

            //                       0               1              2               3                4                5              6
            string[] dienos = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };

            Console.WriteLine(dienos[0]);
            Console.WriteLine(dienos[3]);
            dienos[3] = "Sestadienis";
            Console.WriteLine(dienos[3]);
            var pasirinktaDiena = "Penktadienis";
            dienos[3] = pasirinktaDiena;
            Console.WriteLine(dienos[3]);
            Console.WriteLine(dienos[5]);
            Console.WriteLine(dienos[3]);
            //Console.WriteLine(dienos[7]); NETEISINGA

            //dienos = new string[10];

            Console.WriteLine($"Masyvu irasu kiekis: {dienos.Length}");

            char[] testinisZodisIsChar = { 't', 'e' };
            string testinisZodis = "testinis";

            // String yra sudarytas is char masyvo
            for (int i = 0; i < testinisZodis.Length; i++)
            {
                Console.WriteLine(testinisZodis[i]);
            }

            // Visu masyvo irasu atspausdinimas
            for (int i = 0; i < dienos.Length; i++)
            {
                Console.WriteLine(dienos[i]);
            }

            // Matricos/Dvimacio masyvo deklaravimas
            int[][] dvimatisMasyvas = new int[4][];
            int[,] dvimatisMasyvas2 = new int[4, 5];


            // Dvimacio masyvo irasu deklaravimas
            int[,] dvimatisMasyvasKableliu = new int[,]
                { { 1, 2},
                { 3, 4 },
                { 4, 5 } };

            int[,] dvimatisMasyvas3 = new int[3, 2]
                { { 1, 2},
                { 3, 4 },
                { 4, 5 } };

            for (int i = 0; i < dvimatisMasyvas3.GetLength(0); i++)
            {
                for (int j = 0; j < dvimatisMasyvas3.GetLength(1); j++)
                {
                    Console.Write($"{dvimatisMasyvas3[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        /*
         * 1.Parasykite programa, kuri atspausdintu sia figura pvz:
            1 
            01
            101 
            0101 
            10101
         */

        /*
         * 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. Naudoti tik ciklus ir matematines operacijas.
         * Visi kintamieji yra integer tipo. Pvz:
            Ivedam- 12345 (int)
            Rezultatas-54321 (int)
        */

        /*
         * 3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
         * Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
         * Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
                Pvz: 
                3
                Edvinas
                Jonas
                Petras
        -----------------------------
                Petras
                Jonas
                Edvinas
         */

        /*
         * 4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
         * Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
         * Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. 
         * BONUS: Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            Pvz: 
            3
            Edvinas
            Jonas
            Petras
        ----------------------
            Edvinas
         */

        /*
         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
         * PVZ: 1,2,2,4,2,7,6,1
         * Pasikartojantys skaiciai: 1, 2
         */
        public static string PasikartojantysSkaiciaiMasyve(int[] mas)
        {
            var sb = new StringBuilder();

            var skaiciai = string.Join(";", mas);
            for (int i = 0; i < mas.Length; i++)
            {
                var ind = skaiciai.IndexOf(mas[i].ToString());
                var indLast = skaiciai.LastIndexOf(mas[i].ToString());
                if (ind != indLast)
                {
                    sb.Append(mas[i] + ",");
                }
                skaiciai = skaiciai.Replace(mas[i].ToString(), string.Empty);
            }


            return sb.ToString().TrimEnd(',');
        }

        /*
         * 6. Programa praso ivesti eiluciu ir stulpeliu kieki. 
         * Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno 
         * elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
            PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
        */

        /*
         * 7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame 
         * dvimaciame masyve ir juos atvaizduotu ekrane
        */

        /*
         * 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
        */



        public static void IsgautiAtvirksciaSkaiciu()
        {
            int skaicius = 0,
                likutis,
                rezultatas = 0;

            bool validu = false;

            while (!validu)
            {
                Console.WriteLine("Iveskite skaicius:");
                if (int.TryParse(Console.ReadLine(), out skaicius))
                {
                    validu = true;
                }
            }

            while (skaicius != 0)
            {
                likutis = skaicius % 10;
                Console.WriteLine($"Likutis: {likutis}");
                rezultatas = rezultatas * 10 + likutis; // 123
                Console.WriteLine($"Rezultatas: {rezultatas}");
                skaicius = skaicius / 10;
                Console.WriteLine($"Skaicius: {skaicius}");
            }

            Console.WriteLine($"Rezultatas: {rezultatas}");
        }
    }
}