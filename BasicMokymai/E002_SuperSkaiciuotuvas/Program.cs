namespace E002_SuperSkaiciuotuvas;

public class Program
{
    public static double? rezultatas = null;
    public static double? sk1;
    public static double? sk2;
    public static List<string> simuliuotiVeiksmai = new List<string>();
    public static int i = 0;


    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Skaiciuotuve!");
        PirmasMainMeniu();
    }

    public static void SuperSkaiciuotuvas(string ivedimas)
    {
        simuliuotiVeiksmai.Add(ivedimas);
    }
    static string FakeIvedimas()
    {
        if (simuliuotiVeiksmai.Count <= 0) { return Console.ReadLine(); }
        if (simuliuotiVeiksmai.Count > i) { return simuliuotiVeiksmai[i++]; }
        return "-1";
    }



    public static void SkaiciuIvedimoMetodas()
    {
        Console.WriteLine("Iveskite 1 skaiciu");
        string sk1temp = FakeIvedimas();
        double sk1t;
        bool success1 = double.TryParse(sk1temp, out sk1t);
        sk1 = sk1t;
        if (!success1) Console.WriteLine("neskaicius ");

        Console.WriteLine("Iveskite 2 skaiciu");
        string sk2temp = FakeIvedimas();
        double sk2t;
        bool success2 = double.TryParse(sk2temp, out sk2t);
        sk2 = sk2t;
        if (!success2) Console.WriteLine("neskaicius ");
    }
    public static void PirmasMainMeniu()
    {
        Console.WriteLine(" 1. Nauja operacija \n 2. Testi su rezultatu \n 3. Iseiti. ");
        string mainMeniu = Convert.ToString(FakeIvedimas());
        switch (mainMeniu)
        {
            case "1":
                // 1. Nauja operacija
                AntrasSubMeniu();
                break;

            case "2":
                //  2. Testi su rezultatu
                Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                string antrasSubmeniu = Convert.ToString(FakeIvedimas());
                switch (antrasSubmeniu)
                {
                    case "1":
                        Console.WriteLine("Iveskite 2 skaiciu");
                        sk1 = rezultatas;
                        sk2 = Convert.ToInt32(FakeIvedimas());
                        Console.WriteLine(SudetiSkaicius());
                        PirmasMainMeniu();
                        break;
                    case "2":
                        Console.WriteLine("Iveskite 2 skaiciu");
                        sk1 = rezultatas;
                        sk2 = Convert.ToInt32(FakeIvedimas());
                        Console.WriteLine(AtimtiSkaicius());
                        PirmasMainMeniu();
                        break;
                    case "3":
                        Console.WriteLine("Iveskite 2 skaiciu");
                        sk1 = rezultatas;
                        sk2 = Convert.ToInt32(FakeIvedimas());
                        Console.WriteLine(DaugintiSkaicius());
                        PirmasMainMeniu();
                        break;
                    case "4":
                        Console.WriteLine("Iveskite 2 skaiciu");
                        sk1 = rezultatas;
                        sk2 = Convert.ToInt32(FakeIvedimas());
                        Console.WriteLine(DalintiSkaicius());
                        PirmasMainMeniu();
                        break;
                    case "5":
                        sk1 = rezultatas;
                        Console.WriteLine(LaipsniuKelimoSkaicius());
                        PirmasMainMeniu();
                        break;
                    case "6":
                        sk1 = rezultatas;
                        Console.WriteLine(SakniesTraukimoSkaicius());
                        PirmasMainMeniu();
                        break;

                    default:
                        Console.WriteLine("Nera tokio meniu");
                        break;
                }

                break;
            case "3":
                Console.WriteLine("Exit");
                if (simuliuotiVeiksmai.Count <= 0)
                {
                    System.Environment.Exit(-1);
                    break;
                }
                else
                {
                    return;
                }
            default:
                Console.WriteLine("Nera tokio meniu");
                break;



        }
    }
    public static void AntrasSubMeniu()
    {
        Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
        string pirmasSubmeniu = Convert.ToString(FakeIvedimas());
        switch (pirmasSubmeniu)
        {
            case "1":
                SkaiciuIvedimoMetodas();
                Console.WriteLine(SudetiSkaicius());
                PirmasMainMeniu();
                break;
            case "2":
                SkaiciuIvedimoMetodas();
                Console.WriteLine(AtimtiSkaicius());
                PirmasMainMeniu();
                break;
            case "3":
                SkaiciuIvedimoMetodas();
                Console.WriteLine(DaugintiSkaicius());
                PirmasMainMeniu();
                break;
            case "4":
                SkaiciuIvedimoMetodas();
                Console.WriteLine(DalintiSkaicius());
                PirmasMainMeniu();
                break;
            case "5":
                Console.WriteLine("Iveskite 1 skaiciu");
                sk1 = Convert.ToInt32(FakeIvedimas());
                Console.WriteLine(LaipsniuKelimoSkaicius());
                PirmasMainMeniu();
                break;
            case "6":
                Console.WriteLine("Iveskite 1 skaiciu");
                sk1 = Convert.ToInt32(FakeIvedimas());
                Console.WriteLine(SakniesTraukimoSkaicius());
                PirmasMainMeniu();
                break;
            default:
                Console.WriteLine("Nera tokio meniu");
                break;
        }
    }

    public static double? SudetiSkaicius()
    {
        rezultatas = sk1 + sk2;
        return rezultatas;
    }
    public static double? AtimtiSkaicius()
    {
        rezultatas = sk1 - sk2;
        return rezultatas;
    }
    public static double? DaugintiSkaicius()
    {
        rezultatas = sk1 * sk2;
        return rezultatas;
    }
    public static double? DalintiSkaicius()
    {
        if (sk2 == 0)
        {
            Console.WriteLine("negalima dalinti is nulio");
        }
        rezultatas = sk1 / sk2;
        return rezultatas;
    }
    public static double? LaipsniuKelimoSkaicius()
    {
        int valSqr = 0;
        for (int i = 0, j = 1; i < sk1; i++, j += 2)
            valSqr += j;

        rezultatas = valSqr;
        return rezultatas;
    }
    public static double? SakniesTraukimoSkaicius()
    {
        double root = 1;
        int i = 0;
        double sk1saknis = (double)sk1;
        while (true)
        {
            i = i + 1;
            root = (sk1saknis / root + root) / 2;
            if (i == sk1saknis + 1) { break; }
        }
        rezultatas = root;
        return rezultatas;

    }




    public static double Rezultatas()
    {
        PirmasMainMeniu();
        return rezultatas ?? 0;
    }
    public static void Reset()
    {
        rezultatas = null;
    }



}