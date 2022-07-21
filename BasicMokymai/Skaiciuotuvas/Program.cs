namespace Skaiciuotuvas
{
    internal class Program
    {
        public static double number1;
        public static double number2;
        public static double result;


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
            var isInputNumber = double.TryParse(input, out double choice);

            switch (choice)
            {
                case 1:
                    SubMenu();
                    break;
                case 2:
                    ContinueWithResult(number1, number2);
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
            var isInput2Number = double.TryParse(input2, out double choice2);

            switch (choice2)
            {
                case 1:
                    InputTwoNumbers(out number1, out number2);
                    Console.WriteLine($"Rezultatas: {Addition(number1, number2)}");
                    break;
                case 2:
                    InputTwoNumbers(out number1, out number2);
                    Console.WriteLine($"Rezultatas: {Substraction(number1, number2)}");
                    break;
                case 3:
                    InputTwoNumbers(out number1, out number2);
                    Console.WriteLine($"Rezultatas: {Multiplication(number1, number2)}");
                    break;
                case 4:
                    InputTwoNumbers(out number1, out number2);
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

        public static double ContinueWithResult(double number1, double number2)
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            var input2 = Console.ReadLine();
            var isInput2Number = double.TryParse(input2, out double choice2);
            switch (choice2)
            {
                case 1:
                    InputThirdNumber(out double number3);
                    result = Addition(number1, number2) + number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 2:
                    InputThirdNumber(out number3);
                    result = Substraction(number1, number2) - number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 3:
                    InputThirdNumber(out number3);
                    result = Multiplication(number1, number2) * number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                case 4:
                    InputThirdNumber(out number3);
                    result = Division(number1, number2) / number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    return result;

                default:
                    while (choice2 > 4 || choice2 < 1)
                    {
                        Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                        input2 = Console.ReadLine();
                        ContinueWithResult(number1, number2);
                    }
                    return ContinueWithResult(number1, number2);
            }
        }


        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Substraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Division(double number1, double number2)
        {
            return number1 / number2;
        }



        //---------------------------------------------------------------------------------
        public static double InputTwoNumbers(out double number1, out double number2)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu:");
            number2 = Convert.ToDouble(Console.ReadLine());

            return 0;
        }
        public static double InputThirdNumber(out double number3)
        {
            Console.WriteLine("Iveskite sekanti skaiciu:");
            number3 = Convert.ToDouble(Console.ReadLine());
            return number3;
        }
    }
}