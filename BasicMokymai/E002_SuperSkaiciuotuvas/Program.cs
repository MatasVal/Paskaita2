namespace E002_SuperSkaiciuotuvas
{
    /* ## Super Skaiciuotuvas ## 
        Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
        1. Nauja operacija 2 Iseiti. 
        
        Pasirinkus 1 vada į submeniu:
        1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    
        Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
        1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
        Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
        Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
    
    Pvz:
    > 1. Nauja operacija 2 Iseiti. 
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _1
    > pasirinktas veiksmas + 
    > iveskite pirma skaiciu
    _15
    > iveskite antra skaiciu
    _45
    > Rezultatas: 60
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _2
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas - 
    > Iveskite skaiciu
    _10
    > Rezultatas: 50
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas * 
      > iveskite pirma skaiciu
    _2
    > iveskite antra skaiciu
    _3
    > Rezultatas: 6
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _3
    > Baigta
     
    
    
    BONUS1: Iskelkite operacijas i metodus
    BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
            - dalyba is nulio, neteisingu ivesciu prevencija 
            - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            - neteisingas meniu punkto pasirinkimas
    BONUS3: Parasyti unit testus uztikrinant operaciju veikima
    BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
    
       */
    public class Program
    {
        public static double number1;
        public static double number2;
        public static double result;
        static double? rezultatas = null;


        static void Main(string[] args)
        {
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
            Console.WriteLine();
            Console.WriteLine("1.Nauja operacija\n2.Testi su rezultatu\n3.Iseiti");
            switch (InputValidated())
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
                    Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                    CalculatorMenu();
                    break;
            }
        }


        public static void SubMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            switch (InputValidated())
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
                    Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                    SubMenu();
                    break;
            }
            CalculatorMenu();
        }

        public static double ContinueWithResult(double number1, double number2)
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            switch (InputValidated())
            {
                case 1:
                    InputThirdNumber(out double number3);
                    result = Addition(number1, number2) + number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    CalculatorMenu();
                    return result;

                case 2:
                    InputThirdNumber(out number3);
                    result = Substraction(number1, number2) - number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    CalculatorMenu();
                    return result;

                case 3:
                    InputThirdNumber(out number3);
                    result = Multiplication(number1, number2) * number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    CalculatorMenu();
                    return result;

                case 4:
                    InputThirdNumber(out number3);
                    result = Division(number1, number2) / number3;
                    Console.WriteLine($"Rezultatas: {result}");
                    CalculatorMenu();
                    return result;

                default:
                    Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
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
        public static double? InputTwoNumbers(out double number1, out double number2)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Iveskite antraji skaiciu:");
            double.TryParse(Console.ReadLine(), out number2);
            return null;
        }
        public static double InputThirdNumber(out double number3)
        {
            Console.WriteLine("Iveskite sekanti skaiciu:");
            double.TryParse(Console.ReadLine(), out number3);
            return number3;
        }
        public static double InputValidated()
        {
            double.TryParse(Console.ReadLine(), out double choice);
            return choice;
        }






        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            //todo
        }

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            //todo
            rezultatas = null;
        }



    }



}