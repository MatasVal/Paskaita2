namespace Skaiciuotuvas
{
    internal class Program
    {
        public static int number1;
        public static int number2;
        public static int result;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For skaiciuotuvas!");
                      
            CalculatorMenu();
        }
        

    //Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
    //1. Sudetis
    //2. Atimtis
    //3. Daugyba
    //4. Dalyba”
    //Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
    //o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
    //“1
    //15
    //45
    //Rezultatas: 60
    //1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
    //Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
    //Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
    //BONUS1: Iskelkite operacijas i metodus
    //BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
    //Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
    //BONUS3: Parasyti unit testus uztikrinant operaciju veikima
    //BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
         
        public static void CalculatorMenu()
        {
            Console.WriteLine("1.Nauja operacija\n2.Testi su rezultatu\n3.Iseiti");
            var input = Console.ReadLine();
            var isInputNumber = int.TryParse(input, out int choice);

            switch (choice)
            {
                case 1:
                    SubMenu();
                    break;
                case 2:
                    ContinueWithResult(number1, number2, out result);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    while (choice > 3 || choice < 1)
                    {
                        Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                        input = Console.ReadLine();
                        CalculatorMenu();
                    }
                    break;
            }

        }


        public static void SubMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            var input2 = Console.ReadLine();
            var isInput2Number = int.TryParse(input2, out int choice2);

            switch (choice2)
            {
                case 1:
                    Console.WriteLine("Iveskite pirmaji skaiciu:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite antraji skaiciu:");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rezultatas: {Addition(number1, number2)}");
                    break;
                case 2:
                    Console.WriteLine("Iveskite pirmaji skaiciu:");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite antraji skaiciu:");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rezultatas: {Substraction(number1, number2)}");
                    break;
                case 3:
                    Console.WriteLine("Iveskite pirmaji skaiciu:");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite antraji skaiciu:");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rezultatas: {Multiplication(number1, number2)}");
                    break;
                case 4:
                    Console.WriteLine("Iveskite pirmaji skaiciu:");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite antraji skaiciu:");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rezultatas: {Division(number1, number2)}");
                    break;
                default:
                    while (choice2 > 4 || choice2 < 1)
                    {
                        Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                        input2 = Console.ReadLine();
                        SubMenu();
                    }
                    break;
            }

            CalculatorMenu();

        }

        public static int ContinueWithResult(int number1, int number2, out int result)
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            var input2 = Console.ReadLine();
            var isInput2Number = int.TryParse(input2, out int choice2);
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("Iveskite sekanti skaiciu:");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    result = Addition(number1, number2) + number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 2:
                    Console.WriteLine("Iveskite sekanti skaiciu:");
                    number3 = Convert.ToInt32(Console.ReadLine());
                    result = Substraction(number1, number2) - number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 3:
                    Console.WriteLine("Iveskite sekanti skaiciu:");
                    number3 = Convert.ToInt32(Console.ReadLine());
                    result = Multiplication(number1, number2) * number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 4:
                    Console.WriteLine("Iveskite sekanti skaiciu:");
                    number3 = Convert.ToInt32(Console.ReadLine());
                    result = Division(number1, number2) / number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                default:
                    while (choice2 > 4 || choice2 < 1)
                    {
                        Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                        input2 = Console.ReadLine();
                        ContinueWithResult(number1, number2, out result);
                    }
                    return ContinueWithResult(number1, number2, out result);
            }
        }


        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Division(int number1, int number2)
        {
            return number1 / number2;
        }



        //---------------------------------------------------------------------------------
        public static void InputTwoNumbers(out int number1, out int number2)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu:");
            number2 = Convert.ToInt32(Console.ReadLine());
        }

    }
}