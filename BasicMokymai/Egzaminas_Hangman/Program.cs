﻿using System.Text;

namespace Egzaminas_Hangman
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra", "Salomėja" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };

        //public static List<string> namesList = new List<string> { };
        //public static List<string> citiesList = new List<string> { };
        //public static List<string> countriesList = new List<string> { };
        //public static List<string> otherList = new List<string> { };

        public static List<string> usedRandomWordList = new List<string> { };

        public static List<char> randomWordConvertedToListOfChars = new List<char> { };
        public static List<char> guessListWithUnderscores = new List<char> { };
        public static List<char> mistakeList = new List<char> { }; 
        public static int mistakeCount;

        public static string randomWord;
        public static string guessInput;
        public static string topic;
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

        public static bool isCharCorrect;

        
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
            Console.InputEncoding = Encoding.GetEncoding(1200); //kad konsole isvedinetu lietuviskas raides
                                                                
            Menu();            
        }
        //public static void ArrayToList()
        //{
        //    namesList = names.ToList();
        //    citiesList = cities.ToList();
        //    countriesList = countries.ToList();
        //    otherList = other.ToList();
        //}

        #region Menu and Choices
        public static void Menu()
        {
            //ArrayToList();
            Console.Clear();
            AvailableChoices();
            switch (MenuChoice())
            {
                case 1:
                    topic = "Vardai";
                    GuessingPage();
                    break;
                case 2:
                    topic = "Lietuvos miestai";
                    GuessingPage();
                    break;
                case 3:
                    topic = "Valstybės";
                    GuessingPage();
                    break;
                case 4:
                    topic = "Kita";
                    GuessingPage();
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
        #endregion

        #region Random

        public static string Random()
        {
            if (menuChoice == 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(names.Length);
                randomWord = names[index];                
                RetryIfUsedName();
                return randomWord.ToLower();
            }
            else if (menuChoice == 2)
            {
                Random rnd = new Random();
                int index = rnd.Next(cities.Length);
                randomWord = cities[index];
                RetryIfUsedCity();
                return randomWord.ToLower();
            }
            else if (menuChoice == 3)
            {
                Random rnd = new Random();
                int index = rnd.Next(countries.Length);
                randomWord = countries[index];
                RetryIfUsedCountry();
                return randomWord.ToLower();
            }
            else if (menuChoice == 4)
            {
                Random rnd = new Random();
                int index = rnd.Next(other.Length);
                randomWord = other[index];
                RetryIfUsedOther();
                return randomWord.ToLower();
            }
            else
            {
                return null;
            }
        }
        #endregion    
        public static string RetryIfUsedName()
        {         
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            randomWord = names[index];   

            if (usedRandomWordList.Contains(randomWord))
            {
                RetryIfUsedName();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RetryIfUsedCity()
        {
            Random rnd = new Random();
            int index = rnd.Next(cities.Length);
            randomWord = cities[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RetryIfUsedCity();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RetryIfUsedCountry()
        {
            Random rnd = new Random();
            int index = rnd.Next(countries.Length);
            randomWord = countries[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RetryIfUsedCountry();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RetryIfUsedOther()
        {
            Random rnd = new Random();
            int index = rnd.Next(other.Length);
            randomWord = other[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RetryIfUsedOther();
                return null;
            }
            else
            {
                return randomWord;
            }
        }

        public static void GuessingPage()
        {            
            while (guessListWithUnderscores.Contains('_') || mistakeCount != 6)
            {                
                GuessPageStandart();

                if (isCharCorrect == true)
                {
                    UnderscoreToChar();
                }
                else
                {
                    MistakeCounting();
                }                
                Console.Clear();                
            }            
        }

        public static void RandomWordToCharList()
        {
            randomWordConvertedToListOfChars = Random().ToList();            
        }
        public static List<char> ReplaceCharsWithSpaces()//uz kiekviena raide liste isveda po bruksneli
        {
            foreach (var letter in randomWordConvertedToListOfChars)
            {
                guessListWithUnderscores.Add('_');
            }return guessListWithUnderscores;
        }

        #region Char or Word
        public static void IsGuessInputCharOrWord()
        {
            if(guessInput == null) //jeigu guess input yra default reiksme ir testas nepadave jos, prasome naudotojo ivesti reiksme
            {
                GuessPageStandart();

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

        public static string GuessInput()
        {
            guessInput = Console.ReadLine();
            guessInput = guessInput.ToLower();
            return guessInput; //ToLower, nes reikia kad ivestis butu lowercase - nereiktu ir case'o spelioti
        }

        public static void GuessPageStandart()
        {
            
            if (guessInput == null)
            {
                RandomWordToCharList();
                ReplaceCharsWithSpaces();
            }
            if (guessListWithUnderscores.Contains('_') == false)
            {
                Congratulations();  
            }
            Console.Clear();
            Console.WriteLine($"Tema: {topic}");
            Console.WriteLine();
            Picture();
            Console.WriteLine();
            MistakeDisplay();
            Console.WriteLine($"Žodis: {string.Join(" ", guessListWithUnderscores)}");
            Console.WriteLine();
            Console.WriteLine("Spėkite raidę ar žodį:");
            GuessInput();
            IsGuessInputCharOrWord();                     

        }                

        public static void GuessInputChar() 
        {            
            guessInputChar = Convert.ToChar(guessInput);
            IsCharCorrect();
        }
        public static bool IsCharCorrect()
        {
            if (randomWordConvertedToListOfChars.Contains(guessInputChar) == true)
            {
                return isCharCorrect = true;
            }
            else
            {
                return isCharCorrect = false;
            }
        }
        #endregion


        #region Is Word/List Correct
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
        public static void IsGuessedListCorrect()
        {
            if (guessListWithUnderscores == randomWordConvertedToListOfChars)
            {
                Congratulations();
            }
            else
            {
                BetterLuckNextTime();
            }
        }

        public static int RandomWordLength()
        {
            int randomWordLength = Random().Length;
            return randomWordLength;
        }

        #endregion

        public static List<int> IndexOfCharFromList()
        {
            indices.Clear();
            for (int i = 0; i < randomWordConvertedToListOfChars.Count; i++)
            {
                if (randomWordConvertedToListOfChars[i] == guessInputChar)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static void ReplaceElementAt()
        {            
            foreach (var index in indices)
            {
                guessListWithUnderscores.RemoveAt(index);
                guessListWithUnderscores.Insert(index, guessInputChar);
            }
        }
        public static void UnderscoreToChar()
        {
            if (guessListWithUnderscores.Contains(guessInputChar))
            {
                GuessPageStandart();
            }
            else
            {
                IndexOfCharFromList();
                ReplaceElementAt();
            }
        }       
        #region Mistakes
        
        public static void MistakeCounting()
        {
            if (mistakeList.Contains(guessInputChar))
            {
                GuessPageStandart();
            }
            else
            {
                mistakeList.Add(guessInputChar);
                mistakeCount = Convert.ToInt32(mistakeList.Count());
                AddPartForEachMistake();                
            }           
            
        }

        public static void MistakeDisplay()
        {
            Console.WriteLine($"Spėtos raidės: {string.Join(" ", mistakeList)}");            
        }

        public static void AddPartForEachMistake()
        {
            if (mistakeCount == 1)
            {
                headBool = true;
            }
            else if (mistakeCount == 2)
            {
                rightHandBool = true;
            }
            else if (mistakeCount == 3)
            {
                torsoBool = true;
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
        #endregion

        #region Ending
        public static void Congratulations()
        {
            Console.WriteLine("!!!SVEIKINIMAI!!!");
            Console.WriteLine(":) ŽODIS TEISINGAS :)");
            Console.WriteLine($"Žodis buvo: {randomWord}");//po to kai buves random zodis yra parodomas zaidejui, jis irtraukiamas i panaudotu zodziu sarasa ir randomWord reiksme nunulinama
            usedRandomWordList.Add(randomWord);
            randomWord = null;
            ExitOrContinue();
        }

        public static void BetterLuckNextTime()
        {
            Console.Clear();
            FullHangman();
            Picture();
            Console.WriteLine(":( PRALAIMĖJOTE :(");
            Console.WriteLine($"Žodis buvo: {randomWord}");
            usedRandomWordList.Add(randomWord);
            randomWord = null;
            ExitOrContinue();
        }
        public static string ExitOrContinue()
        {
            Reset();

            Console.WriteLine("Pakartoti žaidimą T/N ?");

            choiceExitOrContinue = Console.ReadLine().ToLower();

            if (choiceExitOrContinue == "t")
            {
                Menu();
            }
            else if (choiceExitOrContinue == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                ExitOrContinue();
            }                     
            return null;
        }
        #endregion
          public static void Reset()
          {
          randomWordConvertedToListOfChars.Clear();
          guessListWithUnderscores.Clear();
          mistakeList.Clear();
          indices.Clear();

          menuChoice = 0;
          mistakeCount = 0;

          guessInput = null;
          topic = null;
          choiceExitOrContinue = null;
          
          guessInputChar = '\0';          
          
          headBool = false;
          torsoBool = false;
          rightHandBool = false;
          leftHandBool = false;
          rightLegBool = false;
          leftLegBool = false;

          isCharCorrect = false;
          }      
        public static void Picture()
        {          
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