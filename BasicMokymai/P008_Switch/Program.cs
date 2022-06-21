namespace P008_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, switch!");
            Console.WriteLine("Iveskite meniu punkta");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Vartotojas pasirinko 1");
                    Console.WriteLine("kazkokia info");
                    break;
                case 2:
                    Console.WriteLine("Vartotojas pasirinko 2");
                    break ;
                    case 3:
                    Console.WriteLine("Vartotojas pasirinko 3");
                    break;
                case 4:
                    Console.WriteLine("Vartotojas pasirinko 4");
                    break;
                default: //galima aprasyti default logika, ji bus vykdoma jei nei vienas case neatitiko salygos
                    Console.WriteLine("Klaida");
                    break;
            }
            Console.WriteLine("---------------------");


            var isvedamasRezultatas = menuChoice switch
            {
                1 => "Vartotojas pasirinko 1",
                2 => "Vartotojas pasirinko 2",
                3 => "Vartotojas pasirinko 3",
                _ => "Vartotojas nieko nepasirinko"
            };
            Console.WriteLine(isvedamasRezultatas);

            switch (menuChoice)
            {
                case 1:
                case 2:
                    Console.WriteLine("Vartotojas pasirinko 1 arba 2");
                    break;
            
            }*/

            Console.WriteLine("iveskite egzamino pazymi:");
            var pazymys = Convert.ToInt32(Console.ReadLine());


            if (pazymys >=0 && pazymys <=4)   
                {
                Console.WriteLine("nepatenkinamai");
            }
            else if (pazymys == 5)
            {
                Console.WriteLine("silpnai");
            }
            else if (pazymys == 6)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (pazymys == 7)
            {
                Console.WriteLine("vidutiniskai");
            }
            else if (pazymys == 8)
            {
                Console.WriteLine("gerai");
            }
            else if (pazymys == 9)
            {
                Console.WriteLine("labai gerai");
            }
            else if (pazymys == 10)
            {
                Console.WriteLine("puikiai");
            }

            Console.WriteLine("------------------------");


            switch (pazymys)
            {
                case 0:
                    Console.WriteLine("nepatenkinamai");
                    break;
                case 1:
                    Console.WriteLine("nepatenkinamai");
                    break;
                case 2:
                    Console.WriteLine("nepatenkinamai");
                    break;
                case 3:
                    Console.WriteLine("nepatenkinamai");
                    break;
                case 4:
                    Console.WriteLine("nepatenkinamai");
                    break;
                case 5:
                    Console.WriteLine("silpnai");
                    break;
                case 6:
                    Console.WriteLine("patenkinamai");
                    break;
                case 7:
                    Console.WriteLine("vidutiniskai");
                    break;
                case 8:
                    Console.WriteLine("gerai");
                    break;
                case 9:
                    Console.WriteLine("labai gerai");
                    break;
                case 10:
                    Console.WriteLine("puikiai");
                    break;


                    Console.WriteLine("------------------------");


                    var isvedamasRezultatas = pazymys switch
                    {
                        0 => "Vartotojas pasirinko 1",
                        1 => "Vartotojas pasirinko 2",
                        2 => "Vartotojas pasirinko 3",
                        3 => "Vartotojas nieko nepasirinko",
                        4 => "Vartotojas nieko nepasirinko",
                        5 => "Vartotojas nieko nepasirinko",
                        6 => "Vartotojas nieko nepasirinko",
                        7 => "Vartotojas nieko nepasirinko",
                        8 => "Vartotojas nieko nepasirinko",
                        9 => "Vartotojas nieko nepasirinko",
                        10 => "Vartotojas nieko nepasirinko",
                    };
                    Console.WriteLine(isvedamasRezultatas);
                    }
            }
        }
    }