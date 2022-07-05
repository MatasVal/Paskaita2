namespace P014_Debug_Savarankiskos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
                     

            Console.WriteLine("Iveskite pirmaji skaiciu:");
            var sk1 = Console.ReadLine();
            Console.WriteLine("Iveskite antraji skaiciu:");
            var sk2 = Console.ReadLine();

            bool sk1YraDouble = double.TryParse(sk1, out _);
                                   
            bool sk2YraDouble = double.TryParse(sk2, out _);


            if (sk1YraDouble || sk2YraDouble)
            {
                Console.WriteLine($"Suma double: {Suma(sk1, sk2)}");
                Console.WriteLine($"Atimtis double: {Atimtis(sk1, sk2)}");
                Console.WriteLine($"Daugyba double: {Daugyba(sk1, sk2)}");
                Console.WriteLine($"Dalyba double: {Dalyba(sk1, sk2)}");
            }
            else
            {
                Console.WriteLine($"Suma: {Suma(sk1, sk2)}");
                Console.WriteLine($"Atimtis: {Atimtis(sk1, sk2)}");
                Console.WriteLine($"Daugyba: {Daugyba(sk1, sk2)}");
                Console.WriteLine($"Dalyba: {Dalyba(sk1, sk2)}");
            }

            Console.WriteLine("Iveskite taisyklingojo daugiakampio kraštinių kiekį:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite taisyklingojo daugiakampio kraštines ilgi:");
            int b = Convert.ToInt32(Console.ReadLine());


            DaugiakampioPlotas_Main(null);


            
        }

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

        public static int Suma(int sk1, int sk2)   //ARBA   public static int Suma(int sk1, int sk2) => sk1 + sk2;      lambda budas?
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
            switch (veiksmas) //state machine
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
        /* Matematika V2
         
        1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)
      2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams.
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
      3. Matematinius metodus palildykite kėlimu kvadratu(^2) ir kėlimu kūbu( ^3).
      4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija)
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3
        */

        public static void MatematikaPapildymas_Main(string[] args) 
        {
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            var sk1 = Console.ReadLine();
            Console.WriteLine("Iveskite antraji skaiciu:");
            var sk2 = Console.ReadLine();
            Console.WriteLine(@"Pasirinkite veiksma
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3");

            var veiksmas = Console.ReadLine();
        }

        public static double Suma(double sk1, double sk2) => sk1 + sk2;

        public static double Atimtis(double sk1, double sk2) => sk1 - sk2;

        public static double Daugyba(double sk1, double sk2) => sk1 * sk2;

        public static double Dalyba(double sk1, double sk2) => sk1 / sk2;


        public static double? Skaiciuotuvas(double sk1, double sk2, string veiksmas)
        {
            switch (veiksmas) //state machine
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



        //Ploto skaiciavimai
        /*
          UŽDUOTIS 2

        Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį(n) ir kraštinės ilgį(b)., 
         metodo parinkimui naudoti switch expression
       1. Kai įvestas trikampis, 
       - paprašyti įvesti aukšį h
       - A=1/2bh
       2. Kai įvestas keturkampis,
       - A=b* b
       3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
       - paprašyti įvesti statmenį r
       - A=n/2 * b* r
       4. išvesti betkokio poligono vidinių kampų sumą
       - 180 * (n - 2)
      N.B! atkreipkite dėmesį į metodų testuojamumą.
        visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami
        */

        public static void DaugiakampioPlotas_Main(string[] args)
        {
            Console.WriteLine("Iveskite taisyklingojo daugiakampio kraštinių kiekį (n):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite taisyklingojo daugiakampio kraštines ilgi (b):");
            int b = Convert.ToInt32(Console.ReadLine());

            int h = 0;
            int r = 0;
            if(n == 3)
            {
                Console.WriteLine("Iveskite trikampio auksti (h):");
                h = Convert.ToInt32(Console.ReadLine());
            }
            else if (n > 4)
            {
                Console.WriteLine("Iveskite daugiakampio statmeni (r):");
                r = Convert.ToInt32(Console.ReadLine());
            }



            var A = PoligonoPlotas(n, b, h, r);
            var S = VidineKampuSuma(n);
            Console.WriteLine($"plotas A = {A}");
            Console.WriteLine($"VidineKampuSuma S = {S}");
        }

        

        public static double PoligonoPlotas(int n, int b, int h, int r) //state machine
        {
            double A = n switch
            {
                3 => TrikampioPlotas(b, h),
                4 => KeturkampioPlotas(b),
                _ => DaugiakampioPlotas (n, b , r), //'_' yra visa kita
            };
            return A;
        }


        public static double TrikampioPlotas(int b, int h) => 1d / 2 * b * h; //d kad butu double ir dalyba butu teisingesne
        
        public static double KeturkampioPlotas(int b) => b * b;

        public static double DaugiakampioPlotas(int n, int b, int r) => n / 2 * b * r;
        
        public static double VidineKampuSuma(int n) => 180 * (n - 2);




    }
}