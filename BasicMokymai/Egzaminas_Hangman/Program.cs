namespace Egzaminas_Hangman
{
    internal class Program
    {
        public static string[] vardai = { "Giedrius", "Mantas", "Domantas", "Lukas", "Eglė", "Liepa", "Margarita", "Viktorija", "Karolis", "Aušra" };
        public static string[] lietuvosMiestai = { "Kaunas", "Klaipėda", "Vilnius", "Šiauliai", "Panevėžys", "Vilkija", "Kelmė", "Plungė", "Tauragė", "Ukmergė", "Utena", "Ignalina", "Zarasai" };
        public static string[] valstybes = { "Graikija", "Švedija", "Nyderlandai", "Danija", "Lenkija", "Vokietija", "Belgija", "Norvegija", "Suomija", "Kanada", "Ispanija", "Portugalija" };
        public static string[] kita = { "Kompiuteris", "Pelė", "Klaviatūra", "Monitorius", "Kabelis", "Pakrovėjas", "Kamera", "Garsiakalbis", "Ausinės", "Mikrofonas" };

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

            
            Menu();            
        }
        public static void Menu()
        {           

                switch (MenuChoice())
                {
                    case 1:                                        
                        Picture();
                        Console.WriteLine("1 pasirinkimas");
                        break;
                    case 2:
                        Console.WriteLine("2 pasirinkimas");
                        break;
                    case 3:
                        Console.WriteLine("3 pasirinkimas");
                        break;
                    case 4:
                        Console.WriteLine("4 pasirinkimas");
                        break;
                    default:
                        Menu();
                        break;
                }
            
        }

        public static void Pasirinkimai()
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
            Pasirinkimai();
            int.TryParse(Console.ReadLine(), out int menuChoice);            

            if (menuChoice >= 1 && menuChoice <= 4)
                {
                Console.Clear();    
                return menuChoice;
                }
            else
                {
                Console.Clear();
                Pasirinkimai();
                Console.WriteLine();
                Console.WriteLine("Netinkamas pasirinkimas, bandykite dar kartą");
                Console.WriteLine();                    
                return 0;
                }
            
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