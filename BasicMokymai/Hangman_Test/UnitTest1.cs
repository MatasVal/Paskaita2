namespace Hangman_Test
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void ChoiceToRandomWord_Test1()
        {
            string[] fakeArray = new string[] { "Giedrius" };//paduodu array is vieno elemento nes random metodas grazins nenuspejama reiksme-testuoti nebus galima                       
            var fake = 1;
            var expected = "giedrius";
            var actual = Hangman_Refactor.Program.ChoiceToRandomWord(fakeArray, fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RandomName_Test()
        {
            string[] fakeArray = new string[] { "Giedrius" };
            var expected = "Giedrius";
            var actual = Hangman_Refactor.Program.RandomName(fakeArray);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RandomWordToCharList_Test()
        {            
            var fake = "Giedrius";
            var expected = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            var actual = Hangman_Refactor.Program.RandomWordToCharList(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceCharsWithSpaces_Test()
        {
            List<char> fakeList = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            //var fake = "Giedrius";
            var expected = new List<char> { '_', '_', '_', '_', '_', '_', '_', '_' };
            var actual = Hangman_Refactor.Program.ReplaceCharsWithSpaces(fakeList);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AreAnyGuessesLeft_Test()
        {
            var fake = "Giedrius";
            var expected = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            var actual = Hangman_Refactor.Program.AreAnyGuessesLeft(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}