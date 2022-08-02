namespace Hangman_Test
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void ChoiceToRandomWord_Test()
        {
            string[] fakeArray = new string[] { "Giedrius" };//paduodu array is vieno elemento nes random metodas grazins nenuspejama reiksme-testuoti nebus galima                
            var fake = 1;
            var expected = "giedrius";
            var actual = Hangman_Refactor.Program.ChoiceToRandomWord(fakeArray, fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RandomName_Test() //testuojam ar metodas paima is listo nepanaudota zodi
        {
            var fakeArray = new string[] { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra", "Salomėja" };
            var fakeUsedWordList = new List <string> { "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra", "Salomėja" }; //panaudotu zodziu liste nėra "Giedrius", todėl metodas turi si varda ir atiduoti           
            var expected = "Giedrius";
            var actual = Hangman_Refactor.Program.RandomName(fakeArray, fakeUsedWordList);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RandomWordToCharList_Test() //testuojam ar zodis paverciamas listu po viena raide
        {            
            var fake = "Giedrius";
            var fakeMenuChoice = 1;
            var expected = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            var actual = Hangman_Refactor.Program.RandomWordToCharList(fakeMenuChoice, fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceCharsWithSpaces_Test()//testuojam ar visos raides yra 'paslepiamos' po underscore'ais
        {
            List<char> fakeList = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };            
            var expected = new List<char> { '_', '_', '_', '_', '_', '_', '_', '_' };
            var actual = Hangman_Refactor.Program.ReplaceCharsWithSpaces(fakeList);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AreAnyGuessesLeft_Test() //testuojam ar grazina null jeigu susirenka 6 klaidos - jeigu grazinamas null- pralaimima
        {
            var fake = 6;            
            string expected = null;
            var actual = Hangman_Refactor.Program.AreAnyGuessesLeft(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsCharCorrect_Test() //testuojam ar ivedus neteisinga raide (char'a) isvedamas false
        {
            List<char> fakeList = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            var fake = 'f';
            bool expected = false;
            var actual = Hangman_Refactor.Program.IsCharCorrect(fakeList, fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfCharFromList_Test() //testuojam ar teisingai isvedami indexai paduodant raide esancia liste
        {
            List<char> fakeList = new List<char> { 'G', 'i', 'e', 'd', 'r', 'i', 'u', 's' };
            var fake = 'i';
            var expected = new List<int> { 1, 5 };
            var actual = Hangman_Refactor.Program.IndexOfCharFromList(fakeList, fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UnderscoreToChar_Test() //testuojam ar teisingai ivedus raide bruksniukai yra keiciami ta raide reikalingose vietose
        {
            var underscoreList = new List<char> { '_', '_', '_', '_', '_', '_', '_', '_' };
            var indexList = new List<int> { 1, 5 };
            var fake = 'i';
            var expected = new List<char> { '_', 'i', '_', '_', '_', 'i', '_', '_' };
            var actual = Hangman_Refactor.Program.UnderscoreToChar(underscoreList, indexList, fake);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToMistakeList_Test() //testuojame ar metodas ivedus neteisinga raide ja prideda i klaidu lista
        {
            var fakeMistakeList = new List <char> { 'a', 'b', 'c', 'd', 'e' };
            char fakeInput = 'f';            
            var expected = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
            var actual = Hangman_Refactor.Program.AddToMistakeList(fakeMistakeList, fakeInput);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MistakeCount_Test() //testuojame ar metodas uz kiekviena klaidu listo elementa priskaiciuoja po klaida
        {
            var fakeList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
            var expected = 6;
            var actual = Hangman_Refactor.Program.MistakeCount(fakeList);
            Assert.AreEqual(expected, actual);
        }        
    }
}