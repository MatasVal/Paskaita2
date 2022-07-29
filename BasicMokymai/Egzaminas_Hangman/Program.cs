using System.Text;

namespace Egzaminas_Hangman
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };

        //public static Dictionary<char, char> randomWordCharDictionary = new Dictionary<char, char> {};

        public static List<char> randomWordConvertedToListOfChars = new List<char> { };
        public static List<char> guessList = new List<char> { };
        public static List<char> MistakeList = new List<char> { }; 
        public static int mistakeCount;

        public static string randomWord;
        public static string guessInput;
        public static char guessInputChar;

        public static List<int> indices = new List<int> { };

        public static int menuChoice;
        public static string choiceExitOrContinue;

        public static bool headBool;
        public static bool torsoBool;
        public static bool rightHandBool;
        public static bool leftHandBool;
        public static bool rightLegBool;
        public static bool leftLegBool;

        public static bool IsCharPresentInHiddenWord;

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
            //Console.WriteLine($"Zodis:{randomWord}");
            //Console.WriteLine($"raide:{randomWordConvertedToListOfChars[1]}");
            ReplaceCharsWithSpaces();
            //RandomWordToCharDictionary();
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
        #endregion


        #region Topics
        public static void Name()
        {
            Console.WriteLine("Tema: Vardai");
            Console.WriteLine();
            Picture();
            IsGuessInputCharOrWord();            
        }
        public static void City()
        {
            Console.WriteLine("Tema: Lietuvos miestai");
            Console.WriteLine();
            Picture();
            IsGuessInputCharOrWord();
        }
        public static void Country()
        {
            Console.WriteLine("Tema: Valstybės");
            Console.WriteLine();
            Picture();
            IsGuessInputCharOrWord();
        }
        public static void Other()
        {
            Console.WriteLine("Tema: Kita");
            Console.WriteLine();
            Picture();
            IsGuessInputCharOrWord();
        }
        #endregion

        public static void ReplaceCharsWithSpaces()//uz kiekviena raide liste isveda po bruksneli, bruksnelius joinina per tarpa
        {
            foreach (var letter in randomWordConvertedToListOfChars)
            {
                guessList.Add('_');                
            }                        
        }

        //foreach letter in char prideti raide o jeigu ne prideti __
        //su foreach tikrinama kiekviena raide ir jeigu tinka isveda ta raide kur reikia
        //vartotojas pildo lista ir jeigu jo listas yra lygus random word listui, jis laimejo

        public static bool IsCharPresentInList()
        {
            if (randomWordConvertedToListOfChars.Contains(guessInputChar) == true)
            {
                return IsCharPresentInHiddenWord = true; 
            }
            else
            {
                return IsCharPresentInHiddenWord = false;                
            }
        }

        public static List<int> IndexOfCharFromList()
        {
            var indices = new List<int>();

            for (int i = 0; i < randomWordConvertedToListOfChars.Count; i++)
            {
                if (randomWordConvertedToListOfChars[i]== guessInputChar)
                {
                    indices.Add(i); 
                }
            }
            return indices;
        }        
        public static void MistakeCounting()
        {
            if(IsCharPresentInHiddenWord == true)
            {
                IndexOfCharFromList();
            }
            else
            {
                foreach(var mistake in MistakeList)
                {
                    mistakeCount = mistakeCount + 1;
                }
            }
        }
        public static void AddPartForEachMistake()
        {
            if (mistakeCount == 1)
            {
                headBool = true;  
            }
            else if (mistakeCount == 2)
            {
                torsoBool = true;
            }
            else if (mistakeCount == 3)
            {
                rightHandBool = true;
            }
            else if (mistakeCount == 4)
            {
                leftHandBool = true;
            }
            else if (mistakeCount == 5)
            {
                rightLegBool = true;
            }
            else if (mistakeCount == 6)
            {
                BetterLuckNextTime();
            }
        }
        
        public static void ReplaceElementAt()
        {
            ReplaceCharsWithSpaces();
            foreach (var index in indices)
            {
                guessList.RemoveAt(index);
                guessList.Insert(index, guessInputChar);
            }            
        }
        public static void UnderscoreToChar()
        {
            IndexOfCharFromList();
            ReplaceElementAt();
        }
        //myList.ElementAt(0)
        //List<T>.IndexOf()
        public static void IsGuessedListCorrect()
        {
            if (guessList == randomWordConvertedToListOfChars)
            {
                Congratulations();
            }
            else
            {
                BetterLuckNextTime();
            }
        }
              

        //public static List<char> GuessList()
        //{
        //    if (randomWordConvertedToListOfChars.)
        //        foreach (var letter in guessList)
        //        {

        //        }

        //}
        
        public static void RandomWordToCharList()
        {
            randomWordConvertedToListOfChars = Random().ToList();            
        }

        #region Char or Word
        public static void IsGuessInputCharOrWord()
        {
            if(guessInput == null) //jeigu guess input yra default reiksme ir testas nepadave jos, prasome naudotojo ivesti reiksme
            {
                RandomWordToCharList();
                ReplaceCharsWithSpaces();
                Console.WriteLine($"Žodis: {guessList}");
                Console.WriteLine("Spėkite raidę ar žodį:");
                guessInput = Console.ReadLine();
                
                    if (guessInput.Length == 1) // nustatome ar naudotojas ivede spejama raide ar visa zodi
                    {
                    GuessInputChar();
                    }
                    else
                    {
                    GuessInputWord();
                    }
            }
            else
            {
                if (guessInput.Length == 1)
                {
                    GuessInputChar();
                }
                else
                {
                    GuessInputWord();
                }
            }
            
        }


        public static char GuessInputChar() 
        {
            if (guessInput == null)
            {
                guessInput = Console.ReadLine();
                return guessInputChar;
            }
            else
            {
                return guessInputChar;
            }
        }
        public static void GuessInputWord() //jei naudotojas iveda zodi, mums netinka charu listas ir turime lyginti random zodi su ivedimu
        {
            if (guessInput == randomWord)
            {
                Congratulations();
            }
            else
            {
                BetterLuckNextTime();
            }
        }
        #endregion

        //public static void RandomWordToCharDictionary()//gal random worda keisti i dictionary ir vienoj puse priskirti raide o value priskirti "_"
        //{
        //    foreach (char letter in randomWordConvertedToListOfChars)
        //    {
        //        randomWordCharDictionary.Add(letter, '_');                
        //    }

        //    //foreach (char letter2.Key in randomWordCharDictionary)
        //    //    {
        //    //    Console.WriteLine("Raktas = {0}, Reiksme = {1}", letter2.Key, miestas.Value);
        //    //}

        //    Console.WriteLine("Raktas = {0}, Reiksme = {1}", randomWordCharDictionary);

        //}


        public static void Congratulations()
        {
            Console.WriteLine("!!!SVEIKINIMAI!!!");
            Console.WriteLine(":) ZODIS TEISINGAS :)");
            Console.WriteLine($" Zodis buvo: {randomWord}");
            Console.WriteLine("Pakartoti zaidima T/ N ?");
            ExitOrContinue();
        }

        public static void BetterLuckNextTime()
        {
            FullHangman();
            Picture();
            Console.WriteLine(":( PRALAIMEJOTE :(");
            Console.WriteLine($" Zodis buvo: {randomWord}");
            ExitOrContinue();
        }
        public static string ExitOrContinue()
        {
            while (choiceExitOrContinue != "t" || choiceExitOrContinue != "n")
            {
                Console.WriteLine("Pakartoti zaidima T/ N ?");
                choiceExitOrContinue = Console.ReadLine();           
            }

            if (choiceExitOrContinue == "t")
            {
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }
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