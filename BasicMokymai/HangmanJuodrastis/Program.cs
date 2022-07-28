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
        
    }
}