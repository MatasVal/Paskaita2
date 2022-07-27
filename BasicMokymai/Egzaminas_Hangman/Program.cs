namespace Egzaminas_Hangman
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };

        public static bool headBool;
        public static bool torsoBool;
        public static bool rightHandBool;
        public static bool leftHandBool;
        public static bool rightLegBool;
        public static bool leftLegBool;

        static void Main(string[] args)
        {
            //- Naudotojas pasirenka iš temų: VARDAI, LIETUVOS MIESTAI, VALSTYBES, KITA. 
            //  (ne mažiau kaip 10 žodžių kiekvienoje grupėje)
            //- Žodis iš pasirinktos grupės parenkamas atsitiktine tvarka.
            //- Užtikrinti kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
            //- Užtikrinti, kad programą nenulūžtu jei vartotojas įveda ne tai ko prašoma
            //- Ėjimas skaitomas tik jei spėjama dar nespėta raidė
            //- Jei spėjamas visas žodis ir neatspėjama - iškarto pralaimima
            //- Parodoma atspėtos raidės vieta žodyje
            //- Parodomos spėtos, bet neatspėtos raidės

            //Apribojimai:
            //- Žodžius saugoti masyvuose arba žodyne.
            //- Kodą skaidyti į metodus.
            //- negalima naudoti OOP ir LINQ

            AvailableChoices();
            Menu();            
        }
        public static void Menu()
        {
            switch (MenuChoice())
            {
                case 1:
                    Console.WriteLine("Tema: Vardai");
                    Console.WriteLine();
                    Picture();
                    Console.WriteLine(RandomName(names));
                    break;
                case 2:
                    Console.WriteLine("Tema: Lietuvos miestai");
                    Console.WriteLine();
                    Picture();
                    Console.WriteLine(RandomCity(cities));
                    break;
                case 3:
                    Console.WriteLine("Tema: Valstybės");
                    Console.WriteLine();
                    Picture();
                    Console.WriteLine(RandomCountry(countries));
                    break;
                case 4:
                    Console.WriteLine("Tema: Kita");
                    Console.WriteLine();
                    Picture();
                    Console.WriteLine(RandomOther(other));
                    break;
                default:
                    Menu();
                    break;
                }
            
        }

        public static void AvailableChoices()
        {
            Console.WriteLine("Pasirinkite temą:");
            Console.WriteLine();
            Console.WriteLine("1. Vardai");
            Console.WriteLine("2. Lietuvos miestai");
            Console.WriteLine("3. Valstybės");
            Console.WriteLine("4. Kita");
        }

        public static int MenuChoice()
        {            
            int.TryParse(Console.ReadLine(), out int menuChoice);            

            if (menuChoice >= 1 && menuChoice <= 4)
                {
                Console.Clear();    
                return menuChoice;
                }
            else
                {
                Console.Clear();
                AvailableChoices();
                Console.WriteLine();
                Console.WriteLine("Netinkamas pasirinkimas, bandykite dar kartą");
                Console.WriteLine();                    
                return 0;
                }
            
        }
        //public static string WhichTopic()
        //{
        //    //if (MenuChoice() == 1 || MenuChoice() == 2 || MenuChoice() == 3 || MenuChoice() == 4)
        //    //{
        //    //    switch (MenuChoice())
        //    //    {
        //    //        case 1:
        //    //            string topic = "Vardai";
        //    //            return topic;
        //    //        case 2:
        //    //            topic = "Lietuvos miestai";
        //    //            return topic;
        //    //        case 3:
        //    //            topic = "Valstybės";
        //    //            return topic;
        //    //        case 4:
        //    //            topic = "Kita";
        //    //            return topic;
        //    //    }
        //    //}
        //    if (MenuChoice() == 1)
        //    {
        //        string topic = "Vardai";
        //        return topic;
        //    }
        //    else if (MenuChoice() == 2)
        //    {
        //        string topic = "Lietuvos miestai";
        //        return topic;
        //    }
        //    else if (MenuChoice() == 3)
        //    {
        //        string topic = "Valstybės";
        //        return topic;
        //    }
        //    else if (MenuChoice() == 4)
        //    {
        //        string topic = "Kita";
        //        return topic;
        //    }

        //}
        //public static void GuessingPage()
        //{
        //    Console.WriteLine($"Tema: {WhichTopic()}");
        //}
        public static string RandomName(string[] names)
        {            
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            return names[index];
        }
        public static string RandomCity(string[] cities)
        {
            Random rnd = new Random();
            int index = rnd.Next(cities.Length);
            return cities[index];
        }
        public static string RandomCountry(string[] countries)
        {
            Random rnd = new Random();
            int index = rnd.Next(countries.Length);
            return countries[index];
        }
        public static string RandomOther(string[] other)
        {
            Random rnd = new Random();
            int index = rnd.Next(other.Length);
            return other[index];
        }

        public static void Picture()
        {
            FullHangman();

            string head = headBool == false ? "" : "O";            //pridedame kuno dalis i paveiksliuka jeigu true
            string torso = torsoBool == false ? "" : "|";            
            string rightHand = rightHandBool == false ? "" : "/";            
            string leftHand = leftHandBool == false ? "" : "\\";            
            string rightLeg = rightLegBool == false ? "" : "/";            
            string leftLeg = leftLegBool == false ? "" : "\\";                  
                        
            Console.WriteLine($"        OOOOOO");
            Console.WriteLine($"     OOOOOOOOOOOO");
            Console.WriteLine($"   OOOOOOOOOOOOOOOO");
            Console.WriteLine($"  OOOOOOOOOOOOOOOOOO");
            Console.WriteLine($" OOOOOOOOOOOOOOOOOOOO");
            Console.WriteLine($"OOOOOOOOOOOOOOOOOOOOOO");
            Console.WriteLine($" OOOOOOOOOOOOOOOOOOOO|");
            Console.WriteLine($"  OOOOOOOOOOOOOOOOOO |");
            Console.WriteLine($"     OOOOOOOOOOOO    |");
            Console.WriteLine($"        OOOOOO       {head}");
            Console.WriteLine($"          ||        {rightHand}{torso}{leftHand}");
            Console.WriteLine($"          ||        {rightLeg} {leftLeg}");
            Console.WriteLine($"          ||");      
        }
                
        public static void FullHangman()
        {
        headBool=true;
        torsoBool = true;
        rightHandBool = true;
        leftHandBool = true;
        rightLegBool = true;
        leftLegBool = true;
        }
    }

}