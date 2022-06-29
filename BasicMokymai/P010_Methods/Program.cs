namespace P010_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("Sukuriame pirma savo metoda");

            IsveskKazkaEkranan(); //metodo kvietimas, kai metodas nieko negrazina ir nieko nepriima

            Console.WriteLine("--------------------------");

            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu(); //metodo kvietimas ir grazinamos reiksmes priskyrimas
            Console.WriteLine($"kazkoksSkaicius = {kazkoksSkaicius}");

            Console.WriteLine("--------------------------");
            int a = 2;

            IsveskSkaiciuEkranan(a); //metodas su vienu parametru
            Console.WriteLine($"skaicius a is Main {a}"); // reiksme nesikeicia is Main
            Console.WriteLine("--------------------------");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintuDuSkaiciai = DaugintiSkaicius(sk1, sk2);

            Console.WriteLine($"sudaugintuDuSkaiciai = {sudaugintuDuSkaiciai}"); //metodas su dviem parametrais grazinantis int

            Console.WriteLine("--------------------------");

            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2);
            Console.WriteLine($"sudaugintiTrysSkaiciai = {sudaugintiTrysSkaiciai}"); //metodo overloadinimas, metodas priima 3 argumentus ir grazina int

            Console.WriteLine("--------------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai}");

            Console.WriteLine("--------------------------");

            double sudaugintiDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d); //auto daromas castinimas, bet daromas explicit kad butu geresnis skaitomumas
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai1}");
            Console.WriteLine("--------------------------");

            IsveskTekstaEkranan();
            IsveskTekstaEkranan("kazkoks tekstas");


            Console.WriteLine("--------------------------");

            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");

            Console.WriteLine("--------------------------");

            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);

            Console.WriteLine($"patikrintasSkaicius = {patikrintasSkaicius}");


            Console.WriteLine("--------------------------");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51); //gerokai skaitomesnis kvietimas per named parametrus
            Console.WriteLine($"patikrintasSkaicius1 = {patikrintasSkaicius1}");

            Console.WriteLine("--------------------------");

            Console.WriteLine("vidurkis" + Vidurkis(2, 3));
            Console.WriteLine("vidurkis1" + Vidurkis(2, 3, 8));
            Console.WriteLine("vidurkis2" + Vidurkis(2, 3, 654, 545, 45, 54, 54, 555, 666));


            Console.WriteLine("--------------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");

            Console.WriteLine("--------------------------");


            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reiksmes perdavimas per reference keicia reiksme kviecianciame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");

            Console.WriteLine("--------------------------");


            //lokalios funkcijos

            int Add(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Add(2, 2));

            //geriau nenaudoti, bet yra


            /* Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
 - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
 N.B.būtina validacija
 - Į ekraną išveskite argumentų matematinę sumą.
 Pvz:
 > Iveskite pirmą skaičių:
 _ 15
 > Iveskite antrą skaičių:
 _ 16
 > Rezultatas: 31*/

            Console.WriteLine("Iveskite pirma skaiciu: ");
            string skA1 = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu: ");
            string skA2 = Console.ReadLine();

            bool arSkA1 = int.TryParse(skA1, out int intSkA1);
            bool arSkA2 = int.TryParse(skA2, out int intSkA2);

            if (arSkA1 && arSkA2)
            {
                MatematineSuma(intSkA1, intSkA2);
            }
            else
            {
                Console.WriteLine("Ivesta blogai");
            }



        }



        public static void MatematineSuma(int intSkA1, int intSkA2)
        {
            Console.WriteLine($"{intSkA1} + {intSkA2}={intSkA1 + intSkA2}");
        }



        //Parašykite programą kurioje yra 2 metodai.
//- Pirmas metodas į konsolę išveda "Sveiki visi"
//- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"


        public static void SveikiVisi()
        {
            Console.WriteLine("sveikiVisi");
        }

       
        public static void Linkiu()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        /*Parašykite programą kurioje yra 2 metodai.
-
- Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
- Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
Pvz:
> Iveskite savo Varda:
_ Petras
> Labas Petras
> Linkiu jums Petras geros dienos*/

        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            
            Console.WriteLine($"Labas {vardas}");
                return vardas;
        }

        public static void Linkiu1()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");

        }

                
        /*Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
- Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
- Main metode į ekraną išveskite tarpų kiekį
Pvz:
> Iveskite teksta:
_ as mokausi programuoti
> Tarpu kiekis yra: 2
        */















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
            return total/skaiciai.Length;
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

        public static double DaugintiSkaicius(double sk1d, double sk2d) //dar karta oveloadintas metodas, bet dabar jau pagal metodo tipa
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
            return a + 4.6864655f;// jeigu nera void yra return
        }

        public static void IsveskKazkaEkranan()
        {

            Console.WriteLine("Isvedu kazka");
        }


    }
}