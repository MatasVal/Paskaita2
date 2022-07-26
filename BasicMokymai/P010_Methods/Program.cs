namespace P010_Methods
{
    public class Program
    {
        static string Tekstas = "";

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, Methods!");

            //int priekyje;
            //KiekYraTarpuPriekyjeIrGale(Console.ReadLine(), out priekyje, out int gale);
            //Console.WriteLine($"priekyje ={priekyje} gale={gale}");

            //int priekyje = KiekYraTarpuPriekyjeIrGale1(Console.ReadLine(), out int gale);
            //Console.WriteLine($"priekyje ={priekyje} gale={gale}");


            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Iveskite teksta");
            Tekstas = Console.ReadLine();
            IsvestiIvestaTeksta();


            Console.WriteLine("Sukuriame pirma savo metoda");

            IsveskKazkaEkranan();//metodo kvietimas. kai metodas nieko negrąžina ir nieko nepriima
            Console.WriteLine("-----------------------");
            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu(); //metodo kvietimas ir grąžinamos reikšmės priskyrimas
            Console.WriteLine($"kazkoksSkaicius = {kazkoksSkaicius}");

            Console.WriteLine("-----------------------");
            int a = 2;
            IsveskSkaiciuEkranan(a); //metodas su vienu parametru
            Console.WriteLine($"skaicius a is Main {a}");
            Console.WriteLine("-----------------------");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2);
            Console.WriteLine($"sudaugintiDuSkaiciai = {sudaugintiDuSkaiciai}"); // metodas su dviem patarmetrais grąžinantis int
            Console.WriteLine("-----------------------");

            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2);
            Console.WriteLine($"sudaugintiTrysSkaiciai = {sudaugintiTrysSkaiciai}"); //metodo overloadinimas, metodas priima 3 argumentus ir grąžina int
            Console.WriteLine("-----------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"sudaugintDuDoubleSkaiciai = {sudaugintDuDoubleSkaiciai}");

            double sudaugintDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d);
            Console.WriteLine($"sudaugintDuDoubleSkaiciai1 = {sudaugintDuDoubleSkaiciai1}");
            Console.WriteLine("-----------------------");

            IsveskTekstaEkranan();
            IsveskTekstaEkranan("kazkoks tekstas");


            Console.WriteLine("-----------------------");

            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");

            Console.WriteLine("-----------------------");
            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine($"patikrintasSkaicius = {patikrintasSkaicius}");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);
            Console.WriteLine($"patikrintasSkaicius1 = {patikrintasSkaicius1}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("vidurkis " + Vidurkis(2, 3));
            Console.WriteLine("vidurkis1 " + Vidurkis(2, 3, 8));
            Console.WriteLine("vidurkis2 " + Vidurkis(2, 3, 545, 87, 3, 78, 32, 78, 21, 65, 45, 121));


            Console.WriteLine("-----------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");
            Console.WriteLine("-----------------------");


            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reikšmės perdavimas per reference keičia reikšme kviečiančiame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");
            Console.WriteLine("-----------------------");


            Console.WriteLine(Add(Convert.ToInt32(Console.ReadLine()), 2));
            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }
        }

        private static void IsvestiIvestaTeksta()
        {
            Console.WriteLine($"ivestas tekstas yra {Tekstas}");
        }






        /*
        Parašykite programą kurioje yra 2 metodai. 
         - Pirmas metodas į konsolę išveda "Sveiki visi"
         - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
        */
        public static void SveikiVisi()
        {
            Console.WriteLine("Sveiki visi");
        }
        public static void LinkiuJumsGerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        /*---------------------------------------------------
       Parašykite programą kurioje yra 2 metodai. 
        - Pirmas metodas naudotojo paprašo įvesti savo vardą ir  į konsolę išveda "Labas tai_kas_ivesta" 
          ir grąžina tai kas ivesta.
        - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta_pirmame_metode geros dienos"
       Pvz: 
       > Iveskite savo Varda:
       _ Petras
       > Labas Petras
       > Linkiu jums Petras geros dienos
       */
        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }
        public static void LinkiuJumsGerosDienos1()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }


        /*---------------------------------------------------
       Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus. 
       - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui. 
         N.B. būtina validacija
       - Į ekraną išveskite argumentų matematinę sumą.
       Pvz: 
       > Iveskite pirmą skaičių:
       _ 15
       > Iveskite antrą skaičių:
       _ 16
       > Rezultatas: 31
       */

        #region UŽDUOTIS 4
        /*---------------------------------------------------
    Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
    - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
    - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį 
    - Main metode į ekraną išveskite tarpų kiekį
    Pvz: 
    > Iveskite teksta:
    _ 'as mokausi programuoti'
    > Tarpu kiekis yra: 2
    */
        #endregion

        #region UŽDUOTIS 5
        /*---------------------------------------------------
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
           Pvz: 
           > Iveskite teksta:
           _ ' as mokausi      '
           > Teksto ilgis yra: 10
        */
        public static int TekstoIlgisBeTarpu(string tekstas)
        {
            return tekstas.Trim().Length;
        }

        #endregion

        #region UŽDUOTIS 6
        /*6---------------------------------------------------
   Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
   - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
   - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
   - Main metode į ekraną išveskite žodžių kiekį
   Pvz: 
   > Iveskite teksta:
   _ as mokausi   programuoti
   > Zodziu kiekis yra: 3
   */
        public static int KiekYraZodziu(string tekstas)
        {
            //return tekstas.Trim().Length - tekstas.Replace(" ", "").Length + 1; 
            return tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }
        #endregion

        #region UŽDUOTIS 7
        /*---------------------------------------------------
       Parašykite programą kurioje vienas metodas. 
       - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
       - Metodas grąžina tarpų kiekį teksto gale
       - Main į ekraną išveda rezultatą
       Pvz: 
       > Iveskite teksta:
       _ ' as mokausi      '
       > Gale yra tarpų: 6
       */
        public static int TarpuGaleKiekis(string tekstas)
        {
            return tekstas.Length - tekstas.TrimEnd().Length;
        }

        #endregion

        #region UŽDUOTIS 8
        /*---------------------------------------------------
       Parašykite programą kurioje vienas metodas. 
       - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
       - Metodas grąžina tarpų kiekį teksto pradžioje
       - Main į ekraną išveda rezultatą
       Pvz: 
       > Iveskite teksta:
       _ ' as mokausi      '
       > Pradžioje yra tarpų: 1
       */
        public static int TarpuPriekyjeKiekis(string tekstas)
        {
            return tekstas.Length - tekstas.TrimStart().Length;
        }
        #endregion

        #region UŽDUOTIS 9
        /*---------------------------------------------------
      Parašykite programą kurioje vienas metodas. 
      - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
      - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
        <hint> naudoti out 
      - Main į ekraną išveda rezultatą
      Pvz: 
      > Iveskite teksta:
      _ ' as mokausi      '
      > Pradžioje yra tarpų: 1
      > Gale yra tarpų: 6
      */
        public static void KiekYraTarpuPriekyjeIrGale(string tekstas, out int priekyje, out int gale)
        {
            priekyje = tekstas.Length - tekstas.TrimStart().Length;
            gale = tekstas.Length - tekstas.TrimEnd().Length;
        }

        public static int KiekYraTarpuPriekyjeIrGale1(string tekstas, out int gale)
        {
            gale = tekstas.Length - tekstas.TrimEnd().Length;
            return tekstas.Length - tekstas.TrimStart().Length;
        }


        #endregion

        #region UŽDUOTIS 10
        /*---------------------------------------------------
    Parašykite programą kurioje yra vienas metodas. 
    - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais 
    - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
    - Main metode į ekraną išveskite metodo darbo rezultatą
    Pvz: 
    > Iveskite teksta:
    _ as mokausi programuoti
    > 'a' raidžių kiekis yra: 3
    */
        public static int KiekYraRaidziuA(string tekstas)
        {
            return tekstas.Length - tekstas.Replace("a", "").Length;
        }

        #endregion

        #region UŽDUOTIS 11 + testai
        /*---------------------------------------------------
    Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip

    Pvz: 
    > Iveskite teksta:
    _ ' as_labai_mokausi_programuoti     '
    > Ar yra mokausi: Taip
    Pvz3:  
    > Iveskite teksta:
    _ ' as_labai_MOKAUSI_programuoti     '
    > Ar yra mokausi: Taip  
    */
        public static string ArYraZodisMokausi(string tekstas)
        {
            return tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";
        }



        #endregion


        #region UŽDUOTIS 11A + testai
        /*---------------------------------------------------
    Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip

    Pvz2: 
    > Iveskite teksta:
    _ ' as_labai_mokausi_programuoti     '
    > Ar yra mokausi: Ne

    Pvz3: 
    > Iveskite teksta:
    _ 'mokausi programuoti labai    '
    > Ar yra mokausi: Taip
    */

        #endregion
        public static string ArYraNesulipesZodisMokausi(string tekstas)
        {
            return (" " + tekstas + " ").Contains(" mokausi ", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";
        }

        #region UŽDUOTIS 12
        /*---------------------------------------------------
      Parašykite programą kurioje yra vienas metodas. 
      - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais 
      - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
      - Main metode į ekraną išveskite metodo darbo rezultatą
      Pvz: 
      > Iveskite teksta:
      _ as mokausi programuoti
      > 'a' raides vieta yra: 0
      */
        #endregion




        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }


        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }








        public static double Vidurkis(params int[] skaiciai)
        {
            double total = 0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }

        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;


        }



        public static void IsveskTekstaEkranan(string tekstas = "tekstas neivestas")
        {
            Console.WriteLine("tekstas - " + tekstas);
        }

        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas - {tekstas}");
        }




        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            float a = 4;
            return a + 4.686878f;
        }

        public static void IsveskKazkaEkranan()
        {
            Console.WriteLine("Isvedu kazka");
        }

    }
}