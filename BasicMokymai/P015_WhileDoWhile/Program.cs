using System;

namespace P015_WhileDoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello While/Do-While Ciklai!");
        }

        public static void WhileCikloPavyzdys()
        {
            int skaicius = 1;

            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }

        public static void WhileCikloZaidejuPavyzdys()
        {
            int zaidejuSkaicius = -1;

            while (zaidejuSkaicius < 0 || zaidejuSkaicius > 10)
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void DoWhilePavyzdys()
        {
            int zaidejuSkaicius = -1;

            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
            } while (zaidejuSkaicius < 0 || zaidejuSkaicius > 10);
        }

        /*
         * 1. Paprasyti vartotojo ivesti bet koki skaiciu.
         * Isvesti skaiciu suma nuo 1 iki ivesto skaiciaus.
         * PVZ: Ivedam 5
         * suma = 1 + 2 + 3 + 4 + 5
         * suma = 15
         */

        public static void PirmoSprendimoApskaiciavimas()
        {
            int i = 0;
            int suma = 0;

            Console.WriteLine("Iveskite skaiciu sumai isgauti:");
            i = Convert.ToInt32(Console.ReadLine());

            while (i > 0)
            {
                Console.WriteLine($"Skaiciuojama suma: {suma}");
                suma += i;
                Console.WriteLine($"i: {suma}\n");
                i--;
            }

            Console.WriteLine($"Suma: {suma}");
        }

        /*
         * 2.Paprasyti vartotojo ivesti bet koki skaiciu.
         * Isvesti visus lyginius skaicius nuo 0 iki pasirinkto skaiciaus
         * vienoje eiluteje per kableli. Pvz: 0, 2, 4, 6....
         */
        public static void AntroSprendimoApskaiciavimas()
        {
            int i = 0;
            int j = 0;

            Console.WriteLine("Iveskite skaiciu sumai isgauti:");
            i = Convert.ToInt32(Console.ReadLine());

            while (j <= i)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }
        }

        /*
         * Parasykite programa, kuri paklaustu naudotojo "skaicius ar herbas"
         * ir naudotojas galetu zaisti iki kol pasieke arba 10 pergaliu
         * arva 10 pralaimejimu
         * 
         * PVZ:
         * 
         * Ivestis:
         * 1. Skaicius
         * 2. Herbas
         * 
         * Naudotojas iveda 2(Herbas)
         * Random(1) = 1
         */

        /*
         * 3.Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma,
         * kurie buvo ivesti iki ivesto paskutinio neigiamo skaiciaus.
         * 
         * PVZ:
         * 1, 23, 4, 5, 7, 8, -1
         */
        public static void TrecioSprendimoApskaiciavimas()
        {
            int suma = 0;
            int ivestis = 0;

            do
            {
                suma += ivestis;
                Console.WriteLine("Iveskite skaiciu: ");
                ivestis = Convert.ToInt32(Console.ReadLine());
            } while (ivestis > 0);

            Console.WriteLine($"Suma: {suma}");
        }

        /*
         6. Parasykite slaptazodzio ivedimo simuliacija. Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi. Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”.          * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.         * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.
         */

        public static void MathRandomPavyzdys()
        {
            Random randomObjektas = new Random();
            int ismestaMoneta = randomObjektas.Next(1, 2);
            int monetosMetimas = 0;

            while (monetosMetimas < 10)
            {
                monetosMetimas++;
            }
        }
    }
}