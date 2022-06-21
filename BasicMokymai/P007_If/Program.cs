namespace P007_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/ Console.WriteLine("Hello, IF!");
             int nelyginisSkaicius = 5;
             int lyginisSkaicius = 2;
             bool tiesa = true;

             if (nelyginisSkaicius > lyginisSkaicius)
             {
                 Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
             }

             if (nelyginisSkaicius < lyginisSkaicius)
             {
                 Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
             }

             Console.WriteLine("if - else");

             if (nelyginisSkaicius < lyginisSkaicius)
             {
                 Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
             }

             else 
             {
                 Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
             }
             Console.WriteLine("---Press any key to continue---");
            */



            //PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
            //-JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
            //- JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
            //- KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ


            /*

                        Console.WriteLine("Iveskite skaiciu:");
                        int skaicius = Convert.ToInt32(Console.ReadLine());



                        if (skaicius % 2 == 0)
                        {
                            Console.WriteLine("Skaicius yra lyginis");
                        }

                        if (skaicius < 0)
                        {
                            Console.WriteLine("Skaicius yra neigiamas");
                        }
                        if (skaicius % 2 != 0 && skaicius < 0)
                        {
                            Console.WriteLine("   Skaicius " + skaicius);
                        }






            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
            VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
            JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA „TAI SOLO ATLIKĖJAS“, 
            JEI NARIŲ KIEKIS 2 --„TAI DUETAS“, 
            JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, 
            JEI DAUGIAU NEI 10 ––„TAI KAMERINIS ANSAMBLIS“.
                        



            Console.WriteLine("Iveskite grupes nariu kieki:");
            var nariuKiekis = Convert.ToInt32(Console.ReadLine());

            if (nariuKiekis == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (nariuKiekis == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if(nariuKiekis > 2 && nariuKiekis < 10)
            {
                Console.WriteLine("Tai ansamblis");
            }
            else if(nariuKiekis > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis"); // su else if gal teisingiau, nes nedaro visu veiksmu o sustoja po pirmojo atitikmens
            }






            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI IŠDIRBTAS VALANDAS.
            JEI VALANDŲ YRA MAŽIAU NEI 160,PROGRAMA TURI PARODYTI, KIEKDAR REIKIA IŠDIRBTI, 
            JEI LYGIAI 160, PARODO, KAD IŠDIRBTAS PILNAS ETATAS, 
            JEI DAUGIAU PARODO KIEK YRA VIRŠVALANDŽIŲ.
            JEI VARTOTOJAS PADARO ĮVEDIMO KLAIDĄ PRANEŠTI IR UŽBAIGTI DARBĄ
            


            Console.WriteLine("Iveskite isdirbtas valandas:");
            var valanduSkaicius = Convert.ToInt32(Console.ReadLine());

            if (valanduSkaicius <160)
            {
                Console.WriteLine($"Liko isdirbti {160 - valanduSkaicius}");
            }

            else if (valanduSkaicius == 160)
            {
                Console.WriteLine("Isdirbtas pilnas etatas");
            }
            else (valanduSkaicius > 160)
            {
                Console.WriteLine($"virsvalandziu skaicius {valanduSkaicius -160}");
            }
            else
            {
                Console.WriteLine("Klaidingas ivedimas")
            }
*/

        }
    }
}