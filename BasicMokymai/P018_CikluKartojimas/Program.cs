using System;
using System.Text;

namespace P018_CikluKartojimas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Ciklu Kartojimas!");

            //// KOMENTARAS APIE REF IR OUT
            //// REF NAUDOJAME TADA KADA DEKLARUOJAME KINTAMAJI PRIES PANAUDOJANT METODA
            //var refSkaicius = 0;
            //RefPavyzdys(ref refSkaicius);
            //// OUT NAUDOJAME TADA KADA NORIME DEKLARUOTI KINTAMAJI NAUDODAMI PARAMETRUS
            //OutPavyzdys(out int outReiksme);
            //Console.WriteLine(outReiksme);


            SkaiciuTrikampisMato();
        }

        /*
         * 1. Uzduotis:
         * Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> .......
            programa turi paprašyti nurodyti skaičių ir grupių kiekį naudokite for ir StringBuilder
         */

        private static void SkaiciuEile(string input, int input2)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input2; i++)
            {
                Console.Write("->");
                sb.Append(input);
                Console.Write(sb);
            }
        }

        /*
         * 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
            15 X 1 = 15                                                                                                   
            15 X 2 = 30                                                                                                   
            15 X 3 = 45                                                                                                   
            15 X 4 = 60                                                                                                   
            15 X 5 = 75                                                                                                   
            15 X 6 = 90                                                                                                   
            15 X 7 = 105                                                                                                  
            15 X 8 = 120                                                                                                  
            15 X 9 = 135                                                                                                  
            15 X 10 = 150
         */
        public static void DaugybosLentele()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius * i);
                Console.WriteLine(sb);
                sb.Clear();
            }
        }

        /*
         * 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “
         * 1. Nauja operacija
         * 2. Testi su rezultatu 
         * 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
            1. Sudetis
            2. Atimtis
            3. Daugyba
            4. Dalyba”
            Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
            “1
            15
            45
            Rezultatas: 60
            1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
            Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
            BONUS1: Iskelkite operacijas i metodus
            BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
        */

        /*
         * 4. Sukurkite programa, kuri atspausdintu sia forma:

                *
               *** 
              *****
             *******
            ********* 
             *******
              *****
               ***
                * 
        */

        public static void SkaiciuTrikampisMato()
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 9:");
            var builder = new StringBuilder();
            int skaicius = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= skaicius; i++)
            {
                while (skaicius > 9 || skaicius < 1)
                {
                    Console.WriteLine("Skaicius neteisingas, bandykite vel:");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }

                builder.Append(skaicius);
                Console.WriteLine(builder.ToString());
            }
        }



        public static void RefPavyzdys(ref int reiksme)
        {
            reiksme = 30;
        }

        public static void OutPavyzdys(out int reiksme)
        {
            reiksme = 30;
        }

        public static bool PaverstiITrisdesimt(int reiksme)
        {
            reiksme = 30;
            return true;
        }

        public static bool PaverstiITrisdesimtOut(out int skaicius, out string sakinys)
        {
            skaicius = 30; // ref-abcd123 out-dddd5878
            sakinys = "Modifikuotas sakinys";
            return true;
        }

        public static void SkaiciuTrikampis()
        {
            var input1 = string.Empty;

            var skaicius = 0;

        }

        public static StringBuilder SudeliotiSakini(int skaicius)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < skaicius; i++)
            {

            }

            return builder;
        }

        private static int SkaiciausTikrinimas(string? txt) => int.TryParse(txt, out int num) == false ? 0 : num;
        private static void PenktaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(skaicius);
                Console.WriteLine(sb.ToString());
            }
            for (int i = skaicius; i >= 1; i--)
            {
                sb.Remove(0, 1);
                Console.WriteLine(sb.ToString());
            }
        }

        private static bool ArValidu(out string input1, out int skaicius)
        {
            while (true)
            {
                input1 = Console.ReadLine();
                var arTeisinga = int.TryParse(input1, out skaicius);
                if (skaicius <= 9 && skaicius >= 1)
                {
                    return true;
                }
            }

            return false;
        }



        /*
         * Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
            (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą). 
            Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
            5
            55
            555
            5555
            55555
         */
    }
}