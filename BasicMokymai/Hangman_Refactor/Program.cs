using System.Text;

namespace Hangman_Refactor
{
    public class Program
    {
        #region Global Vars, Arrays and Lists
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra", "Salomėja" };//11
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };               

        public static List<char> randomWordConvertedToListOfChars = new List<char> { };
        public static List<char> guessListWithUnderscores = new List<char> { };
        public static List<char> mistakeList = new List<char> { };
        public static int mistakeCount;

        public static string? testWord;
        public static string? randomWord;
        public static string? guessInput;
        public static string? topic;
        public static char guessInputChar;

        public static List<int> indexes = new List<int> { };
        public static List<string> usedRandomWordList = new List<string> { };

        public static int menuChoice;
        public static string? choiceExitOrContinue;

        public static bool headBool;
        public static bool torsoBool;
        public static bool rightHandBool;
        public static bool leftHandBool;
        public static bool rightLegBool;
        public static bool leftLegBool;

        public static bool isCharCorrect;
        #endregion
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
                    AreAnyGuessesLeft(mistakeCount);
                    break;
                case 2:
                    topic = "Lietuvos miestai";
                    AreAnyGuessesLeft(mistakeCount);
                    break;
                case 3:
                    topic = "Valstybės";
                    AreAnyGuessesLeft(mistakeCount);
                    break;
                case 4:
                    topic = "Kita";
                    AreAnyGuessesLeft(mistakeCount);
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

        public static string ChoiceToRandomWord(string[] names, int menuChoice)
        {
            if (menuChoice == 1)
            {
                RandomName(names, usedRandomWordList);
                return randomWord.ToLower();
            }
            else if (menuChoice == 2)
            {
                RandomCity();
                return randomWord.ToLower();
            }
            else if (menuChoice == 3)
            {               
                RandomCountry();
                return randomWord.ToLower();
            }
            else if (menuChoice == 4)
            {                
                RandomOther();
                return randomWord.ToLower();
            }
            else
            {
                return null;
            }
        }

        public static List<char> RandomWordToCharList(int menuChoice, string testWord) //random zodi isskaido po raide ir is siu raidziu sukuria lista 
        {
            if (testWord!=null)
            {
            return randomWordConvertedToListOfChars = testWord.ToList(); //tik testavimui, kitaip metodas lenda i kita metoda kuris isrenka random zodi - testas nepraeina
            }
            else 
            {
            return randomWordConvertedToListOfChars = ChoiceToRandomWord(names, menuChoice).ToList();
            }
        }

        public static List<char> ReplaceCharsWithSpaces(List <char> randomWordConvertedToListOfChars)//uz kiekviena raide liste isveda po bruksneli
        {
            foreach (var letter in randomWordConvertedToListOfChars)
            {
                guessListWithUnderscores.Add('_');
            }
            return guessListWithUnderscores;
        }
        #endregion

        #region Random Word Generation and Checking if Used Already

        //metodai kurie isrenka random zodi ir pries paduodami patikrina ar jis dar nebuvo panaudotas
        //sie keturi metodai veikia taip pat, testuojamas tik pirmasis
        public static string RandomName(string[] names, List<string> usedRandomWordList)
        {
            AreThereAnyWordsLeft();
            IsNameTopicExhausted();
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            randomWord = names[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RandomName(names, usedRandomWordList);
                return randomWord;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RandomCity()
        {
            AreThereAnyWordsLeft();
            IsCityTopicExhausted();
            Random rnd = new Random();
            int index = rnd.Next(cities.Length);
            randomWord = cities[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RandomCity();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RandomCountry()
        {
            AreThereAnyWordsLeft();
            IsCountryTopicExhausted();
            Random rnd = new Random();
            int index = rnd.Next(countries.Length);
            randomWord = countries[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RandomCountry();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        public static string RandomOther()
        {
            AreThereAnyWordsLeft();
            IsOtherTopicExhausted();
            Random rnd = new Random();
            int index = rnd.Next(other.Length);
            randomWord = other[index];

            if (usedRandomWordList.Contains(randomWord))
            {
                RandomOther();
                return null;
            }
            else
            {
                return randomWord;
            }
        }
        #endregion

        #region Guessing
        public static string AreAnyGuessesLeft(int mistakeCount)
        {
            while (mistakeCount != 6)//jei dar nera padarytu 6 klaidu - leidziama speti toliau
            {
                GuessPageStandart();

                if (isCharCorrect == true)
                {
                    IsCharAlreadyGuessed();                    
                }
                else
                {
                    MistakeCountingMenu();                    
                }
                Console.Clear();
            } return null; 
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
            FirstGameOrNot();
            CongratulateIfNoLettersLeftToGuess();
            Console.Clear();
            Console.WriteLine($"Tema: {topic}");
            Console.WriteLine();
            Picture();
            Console.WriteLine();
            MistakeDisplay();
            Console.WriteLine();
            Console.WriteLine($"Žodis: {string.Join(" ", guessListWithUnderscores)}");
            Console.WriteLine();
            Console.WriteLine("Spėkite raidę ar žodį:");
            GuessInput();
            IsGuessInputCharOrWord();            
        }

        public static void FirstGameOrNot()
        {
            if (guessInput == null)//jei dar nera jokio spėjimo inputo (zaidziama pirma karta), sugeneruojamas random zodis ir isvedamas listas is "underscore'u"
            {
                RandomWordToCharList(menuChoice, testWord);
                ReplaceCharsWithSpaces(randomWordConvertedToListOfChars);
            }
        }

        public static void CongratulateIfNoLettersLeftToGuess()
        {
            if (guessListWithUnderscores.Contains('_') == false)//jei visos raides atspetos, sveikinama
            {
                Congratulations();                
            }
        }
        #endregion

        #region Char or Word
        public static void IsGuessInputCharOrWord()
        {           
             if (guessInput.Length == 1) // nustatome ar naudotojas ivede spejama raide ar visa zodi
             {
               GuessInputChar();
             }
             else
             {
               GuessInputWord();
             }            
        }
        #endregion

        #region Is Char Correct
        public static void GuessInputChar()
        {
            guessInputChar = Convert.ToChar(guessInput);//konvertuojam input i char, kad input galetu buti lyginamas su random zodziu (kuris yra char'u listas)
            IsCharCorrect(randomWordConvertedToListOfChars, guessInputChar);
        }
        public static bool IsCharCorrect(List<char> randomWordConvertedToListOfChars,char guessInputChar)
        {
            if (randomWordConvertedToListOfChars.Contains(guessInputChar) == true)//priklausomai nuo to ar ivestas char'as yra is random zodzio sudarytame char'u liste isvedame true arba false
            {
                return isCharCorrect = true;
            }
            else
            {
                return isCharCorrect = false;
            }
        }
        #endregion

        #region Finding matching chars and replacing underscores "_" with them
        public static List<int> IndexOfCharFromList(List<char> randomWordConvertedToListOfChars, char guessInputChar)
        {
            indexes.Clear();//isvalome index lista kad nebutu pries tai uzsilikusiu indexu
            for (int i = 0; i < randomWordConvertedToListOfChars.Count; i++)//jei ivestas charas sutampa su bent vienu charu is listo, isvedame tu charu indexus
            {
                if (randomWordConvertedToListOfChars[i] == guessInputChar)
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }

        public static List <char> UnderscoreToChar(List <char> guessListWithUnderscores, List<int> indexes, char guessInputChar)
        {
            foreach (var index in indexes)
            {
                guessListWithUnderscores.RemoveAt(index);//paimame lista sudaryta is 'underscore' (_) ir tose vietose kur buvo atspeta raide istriname bruksniukus
                guessListWithUnderscores.Insert(index, guessInputChar);//ir irasome ta teisingai atspeta raide
            }return guessListWithUnderscores;   
        }
        public static void IsCharAlreadyGuessed()
        {
            if (guessListWithUnderscores.Contains(guessInputChar))//tikriname ar raide jau buvo atspeta
            {
                GuessPageStandart();//jei tokia raide jau buvo atspeta, prasome ivesti kita raide
            }
            else
            {
                IndexOfCharFromList( randomWordConvertedToListOfChars, guessInputChar);//jei tokios raides tarp atspetu dar nera, ieskom jos indexu liste ir juos keiciam naujai atspeta raide
                UnderscoreToChar(guessListWithUnderscores, indexes, guessInputChar);
            }
        }
        #endregion

        #region Is Word/List Correct
        public static void GuessInputWord() //jei naudotojas iveda zodi, mes is karto lyginame ji su random zodziu
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
        public static void IsGuessedListCorrect()//jei spejamame zodyje nebelieka underscore'u (visos raides atspetos po viena) - naudotojas laimi
        {
            if (guessListWithUnderscores == randomWordConvertedToListOfChars)
            {
                Congratulations();
            }            
        }
        #endregion        

        #region Mistakes

        public static void MistakeCountingMenu()
        {
            if (mistakeList.Contains(guessInputChar))//jei mistake list jau turi tokia raide, sugrazinama atgal
            {
                GuessPageStandart();
                
            }
            else//jei tokios raides mistake liste nera, ji yra pridedama
            {
                AddToMistakeList(mistakeList, guessInputChar);
                MistakeCount(mistakeList);
                AddPartForEachMistake();                
            }
        }
        public static List<char> AddToMistakeList(List<char> mistakeList, char guessInputChar)//pridedama raide i mistake lista kaip elementas
        {
            mistakeList.Add(guessInputChar);
            return mistakeList;
        }
        public static int MistakeCount(List<char> mistakeList)//uz kiekviena elementa mistake liste priskaiciuojama po viena vieneta
        {
            return mistakeCount = Convert.ToInt32(mistakeList.Count());
        }

        public static void MistakeDisplay()//is klaidu listo konsoleje sudarinejam neteisingai spetu raidziu sarasa
        {            
            Console.WriteLine($"Spėtos raidės: {string.Join(" ", mistakeList)}");            
        }

        public static void AddPartForEachMistake()//uz kiekviena klaida pridedame po kuno dali
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
            else if (mistakeCount == 6)//jei surinktos 6 klaidos - pralaimima
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
            AddWordToUsedWordList();
            ExitOrContinue();
        }

        public static void BetterLuckNextTime()
        {
            Console.Clear();
            FullHangman();//aktyvuojame visas kuno dalis ir isvedame pilna Hangman'a
            Picture();
            Console.WriteLine(":( PRALAIMĖJOTE :(");
            AddWordToUsedWordList();
            ExitOrContinue();
        }
        public static void AddWordToUsedWordList()//po to kai panaudotas random zodis yra parodomas zaidejui, jis itraukiamas i panaudotu zodziu sarasa ir randomWord reiksme nunulinama
        {
            Console.WriteLine($"Žodis buvo: {randomWord}");
            usedRandomWordList.Add(randomWord);
            randomWord = null;
        }
        public static string ExitOrContinue()
        {
            Reset();//nunulinam dauguma globaliu reiksmiu - kad zaidima butu galima testi, bet jau su kitais random zodziais
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
            else//jei ivedama ne 't' ar 'n', nukreipiama atgal i metoda - pakartotiniam ivedimui
            {
                ExitOrContinue();
            }
            return null;
        }
        #endregion

        #region Picture
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
        #endregion

        #region Reset
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
        #endregion

        #region Any Words Left to Guess? //Tikrinimai, kad pasibaigus zodziams neuzsisuktu amzinas ciklas
        
        public static void IsNameTopicExhausted()//jei temoje nebėra likusių nepanaudotų žodžių, nukreipiama į meniu
        {
            int count = 0;
            foreach (var name in names)//uz kiekviena panaudotu zodziu liste surasta zodi is 'name' masyvo vedam counteri
            {
                if (usedRandomWordList.Contains(name))
                {
                    count++;
                }
            }
            if(count == names.Length)//jei counterio reiksme lygi elementu masyve kiekiui, nukreipiame i Meniu
            {                
                Menu();
            } 
        }
        public static void IsCityTopicExhausted()
        {
            int count = 0;
            foreach (var city in cities)
            {
                if (usedRandomWordList.Contains(city))
                {
                    count++;
                }
            }
            if (count == cities.Length)
            {
                Menu();
            }
        }
        public static void IsCountryTopicExhausted()
        {
            int count = 0;
            foreach (var country in countries)
            {
                if (usedRandomWordList.Contains(country))
                {
                    count++;
                }
            }
            if (count == countries.Length)
            {
                Menu();
            }
        }
        public static void IsOtherTopicExhausted()
        {
            int count = 0;
            foreach (var othr in other)
            {
                if (usedRandomWordList.Contains(othr))
                {
                    count++;
                }
            }
            if (count == other.Length)
            {
                Menu();
            }
        }
        public static void AreThereAnyWordsLeft()//jeigu visi žaidimo žodžiai panaudoti, programa stabdoma
        {

            if (usedRandomWordList.Count == 46)
            {
                Console.WriteLine("Nebeliko spėjamų žodžių, ačiū už žaidimą");
                Environment.Exit(0);
            }
        }     

        #endregion
    }

}