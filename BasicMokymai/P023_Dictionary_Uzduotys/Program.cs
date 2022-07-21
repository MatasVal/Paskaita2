namespace P023_Dictionary_Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AtspausdintiPirmaKlasesDarba();

        }

        //KLASES DARBAS 1. ## Parasykite metoda, kuris priima sveikaji skaiciu kaip parametra ir sukuria nauja zodyna - raktas:x, reiksme:x*x formoje. Pvz: Ivestis-5 1:1 2:4 3:9 4:16 5:25
        public static void AtspausdintiPirmaKlasesDarba()
        {
            var zodynas = PastatytiSkaiciausKvadratoZodyna(5);
            foreach (var skaicius in zodynas)
            {
                Console.Write($"{skaicius.Key}:{skaicius.Value} ");
            }
        }

        public static Dictionary<int, int> PastatytiSkaiciausKvadratoZodyna(int skaicius)
        {
            
            
            var skaiciuZodynas = new Dictionary<int, int>();

            for (int i = 1; i <= skaicius; i++)
            {
                skaiciuZodynas.Add(i, i * i);
            }
            return skaiciuZodynas;
        }


    }
}