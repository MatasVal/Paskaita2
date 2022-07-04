namespace P014_Debug_Savarankiskos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");

            /*
            UŽDUOTIS 1

           1.Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
         -Main metode paprašykite įvesti 2 skaičius
         - Kiekvienas matematinis veiksmas turi turėti savo metodą
           metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
         -Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
         -Visų gautų rezultatų sumą atspausdinti Main metode.

        2.Skaičiuotuvas.Naudoti pirmos dalies matematinius metodus.
         -Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
         -Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą.
         -Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą(naudoti switch)
         -parašyti testus
         - gautą rezultatą atspausdinti į ekraną Main metode.
            */
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Suma: {Suma(sk1, sk2)}");
            Console.WriteLine($"Atimtis: {Atimtis(sk1, sk2)}");
            Console.WriteLine($"Daugyba: {Daugyba(sk1, sk2)}");
            Console.WriteLine($"Dalyba: {Dalyba(sk1, sk2)}");
        }


        public static int Suma(int sk1, int sk2)   //ARBA   public static int Suma(int sk1, int sk2) => a + b;      lambda budas?
        {
            return sk1 + sk2;
        }
        public static int Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }

        public static int Daugyba(int sk1, int sk2)
        {
            return sk1 * sk2;
        }
        public static double Dalyba(int sk1, int sk2)
        {
            return sk1 / sk2;
        }


        public static double? Skaiciuotuvas(int sk1, int sk2, string veiksmas)
        {
            switch (veiksmas)
            {
                case "+":
                    return Suma(sk1, sk2);
                    
                case "-":
                    return Atimtis(sk1, sk2);
                    
                case "*":
                    return Daugyba(sk1, sk2);
                    
                case "/":
                    return Dalyba(sk1, sk2);
                default:
                    return null;
            }
        }
    }
}