namespace HangmanJuodrastis
{
    internal class Program
    {
        public static string[] names = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra" };
        public static string[] cities = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] countries = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] other = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };

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
        static void Main(string[] args)
        {
            //Convert.ToString(Random(names, cities, countries, other)).Replace("", " _");
            Console.WriteLine(RandomWordToChars());
            Console.WriteLine("_________");
        }

        public static string RandomWordToChars()
        {
            char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //array
            string greetings = new string(letters);
            Console.WriteLine(greetings[1]);
            return null;
        }

        public static string WordToCharList()
        {
            List<string> stringSarasas = new List<string> { };
        }

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


        //foreach letter in char prideti raide o jeigu ne prideti __
        //su foreach tikrinama kiekviena raide ir jeigu tinka isveda ta raide kur reikia
        //vartotojas pildo lista ir jeigu jo listas yra lygus random word listui, jis laimejo

        //myList.ElementAt(0)
        //List<T>.IndexOf()

        //public static List<char> GuessList()
        //{
        //    if (randomWordConvertedToListOfChars.)
        //        foreach (var letter in guessList)
        //        {

        //        }

        //}





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

    }
}