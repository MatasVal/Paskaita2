using System.Text;

namespace Hangman_Refactor
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra", "Salomėja" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };               

        public static List<char> randomWordConvertedToListOfChars = new List<char> { };
        public static List<char> guessListWithUnderscores = new List<char> { };
        public static List<char> mistakeList = new List<char> { };
        public static int mistakeCount;

        public static string randomWord;
        public static string guessInput;
        public static string topic;
        public static char guessInputChar;

        public static List<int> indexes = new List<int> { };
        public static List<string> usedRandomWordList = new List<string> { };

        public static int menuChoice;
        public static string choiceExitOrContinue;

        public static bool headBool;
        public static bool torsoBool;
        public static bool rightHandBool;
        public static bool leftHandBool;
        public static bool rightLegBool;
        public static bool leftLegBool;

        public static bool isCharCorrect;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200); //kad konsole isvedinetu lietuviskas raides

            Menu();
        }
        
        #region Menu and Choices
        public static void Menu()
        {
            Console.Clear();
            AvailableChoices();
            MenuChoiceSwitch();           
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
               
        public static void MenuChoiceSwitch()
        {
            MenuChoiceValidated();
            switch (menuChoice)
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
                    Console.Clear();
                    AvailableChoices();
                    Console.WriteLine();
                    Console.WriteLine("Netinkamas pasirinkimas, bandykite dar kartą");
                    Console.WriteLine();
                    MenuChoiceSwitch();
                    break;
            }
        }

        public static int MenuChoiceValidated()
        {
            int.TryParse(Console.ReadLine(), out menuChoice);
            return menuChoice;
        }
        #endregion

        #region Random

        public static string Random()
        {
            if (menuChoice == 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(names.Length);
                randomWord = names[index];//isrenkame random zodi
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

        #region Retry if Word Is Used
        public static string RetryIfUsedName()//kvieciame metoda kuris tikrina ar zodis jau yra panaudotu zodziu sarase, jeigu ne - atiduoda ji atgal, jeigu zodis surandamas tarp panaudotu zodziu, metodas ima kita random zodi ir ji vel tikrina
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
        #endregion
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
            }
            return guessListWithUnderscores;
        }

        public static string GuessInput()
        {           
            guessInput = Console.ReadLine();
            guessInput = guessInput.ToLower();//ToLower, nes reikia kad ivestis butu lowercase - nereiktu ir case'o spelioti

            if (guessInput.Length == 0)
            {
                GuessInput();
            }
            return guessInput; 
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
        #region Char or Word
        public static void IsGuessInputCharOrWord()
        {
            //if (guessInput == null) //jeigu guess input yra default reiksme ir testas nepadave jos, prasome naudotojo ivesti reiksme
            //{
                //GuessPageStandart();

                if (guessInput.Length == 1) // nustatome ar naudotojas ivede spejama raide ar visa zodi
                {
                    GuessInputChar();
                }
                else
                {
                    GuessInputWord();
                }
            //}
            //else//jei guessInput jau turi reiksme. aiskinames ar paduota raide ar zodis
            //{
            //    if (guessInput.Length == 1)
            //    {
            //        GuessInputChar();
            //    }
            //    else
            //    {
            //        GuessInputWord();
            //    }
            //}
        }
        #endregion

        #region Is Char Correct
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
            if (guessInput == randomWord.ToLower())
            {
                Console.Clear();
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
            indexes.Clear();
            for (int i = 0; i < randomWordConvertedToListOfChars.Count; i++)
            {
                if (randomWordConvertedToListOfChars[i] == guessInputChar)
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }

        public static void ReplaceElementAt()
        {
            foreach (var index in indexes)
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
            if (mistakeList.Contains(guessInputChar))//jei mistake list jau turi tokia raide, sugrazinama atgal
            {
                GuessPageStandart();
            }
            else//jei tokios raides mistake liste nera, ji yra pridedama
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
            indexes.Clear();

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
            headBool = true;
            torsoBool = true;
            rightHandBool = true;
            leftHandBool = true;
            rightLegBool = true;
            leftLegBool = true;
        }
    }

}