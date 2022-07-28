using System.Text;

namespace Egzaminas_Hangman
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };
        public static string randomWord;
        public static List<char> randomWordConvertedToListOfChars = new List<char> { };

        //Dictionary<string, string> names = new Dictionary<string, string>
        //{   { "Giedrius", "_ _ _ _ _ _"} 
        //    {"Mantas",} 
        //    {"Domantas",} 
        //    {"Lukas",}
        //    {"Eglė",}
        //    {"Liepa",} 
        //    {"Margarita",} 
        //    {"Viktorija",} 
        //    {"Karolis",} 
        //    {"Aušra"}
        //};

        public static bool headBool;
        public static bool torsoBool;
        public static bool rightHandBool;
        public static bool leftHandBool;
        public static bool rightLegBool;
        public static bool leftLegBool;

        public static int menuChoice;

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
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            AvailableChoices();
            Menu();
            Console.WriteLine($"Zodis:{randomWord}");
            Console.WriteLine($"raide:{randomWordConvertedToListOfChars[0]}");
        }
        public static void Menu()
        {
            switch (MenuChoice())
            {
                case 1:
                    Name();
                    break;
                case 2:
                    City();
                    break;
                case 3:
                    Country();
                    break;
                case 4:
                    Other();
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
            int.TryParse(Console.ReadLine(), out menuChoice);            

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


        #region Random

        public static string Random()
        {
            if (menuChoice == 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(names.Length);
                randomWord = names[index];
                return randomWord;
            }
            else if (menuChoice == 2)
            {
                Random rnd = new Random();
                int index = rnd.Next(cities.Length);
                randomWord = cities[index];
                return randomWord;
            }
            else if (menuChoice == 3)
            {
                Random rnd = new Random();
                int index = rnd.Next(countries.Length);
                randomWord = countries[index];
                return randomWord;
            }
            else if (menuChoice == 4)
            {
                Random rnd = new Random();
                int index = rnd.Next(other.Length);
                randomWord = other[index];
                return randomWord;
            }
            else
            {
                return null;
            }
        }
        //public static string RandomName(string[] names)
        //{            
        //    Random rnd = new Random();
        //    int index = rnd.Next(names.Length);
        //    return names[index];
        //}
        //public static string RandomCity(string[] cities)
        //{
        //    Random rnd = new Random();
        //    int index = rnd.Next(cities.Length);
        //    return cities[index];
        //}
        //public static string RandomCountry(string[] countries)
        //{
        //    Random rnd = new Random();
        //    int index = rnd.Next(countries.Length);
        //    return countries[index];
        //}
        //public static string RandomOther(string[] other)
        //{
        //    Random rnd = new Random();
        //    int index = rnd.Next(other.Length);
        //    return other[index];
        //}
        #endregion 


        #region Topics
        public static void Name()
        {
            Console.WriteLine("Tema: Vardai");
            Console.WriteLine();
            Picture();
            RandomWordToCharList();
            //List<string> name = new List<string> {};

            //Console.WriteLine($"Žodis: {ReplaceCharsWithSpaces(names, cities, countries, other)}");
        }
        public static void City()
        {
            Console.WriteLine("Tema: Lietuvos miestai");
            Console.WriteLine();
            Picture();
            //Console.WriteLine(ReplaceCharsWithSpaces(names, cities, countries, other));
        }
        public static void Country()
        {
            Console.WriteLine("Tema: Valstybės");
            Console.WriteLine();
            Picture();
            //Console.WriteLine(ReplaceCharsWithSpaces(names, cities, countries, other));
        }
        public static void Other()
        {
            Console.WriteLine("Tema: Kita");
            Console.WriteLine();
            Picture();
            //Console.WriteLine(ReplaceCharsWithSpaces(names, cities, countries, other));
        }
        #endregion

        //public static string ReplaceCharsWithSpaces(string[] names, string[] cities, string[] countries, string[] other) 
        //{ 
        //    if (menuChoice == 1)
        //    {
        //        return Convert.ToString(Random(names, cities, countries, other)).Replace("", " _");
        //    }
        //    else if (menuChoice == 2)
        //    {
        //        return Convert.ToString(Random(names, cities, countries, other).Length).Replace("", " _");
        //    }
        //    else if (menuChoice == 3)
        //    {
        //        return Convert.ToString(Random(names, cities, countries, other).Length).Replace("", " _");// turbut nereikia to length nes grazina ilgi-skaiciu
        //    }
        //    else if (menuChoice == 4)
        //    {
        //        return Convert.ToString(Random(names, cities, countries, other).Length).Replace("", " _");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public static string RandomWordToCharList()
        {
            randomWordConvertedToListOfChars = Random().ToList();
            //randomWordConvertedToListOfChars.AddRange(Random(names, cities, countries, other));
            return null;
        }
        public static int RandomWordLength()
        {
            int randomWordLength = Random().Length;
            return randomWordLength;
        }
        public static void Picture()
        {
            //FullHangman();

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