namespace Skaiciuotuvas
{
    /*
        Vietoje globaliu kintamuju galime pasidaryti stukrutizuota saugykla, kurioje
        laikysime viskas kas yra tos pacios kategorijos
    */
    struct user_inputs {
        int a;
        int b;
        int action;
        int result;
    }

    internal class Program
    {

        /* Geriausia naudoti kuo maziau globaliu kintamuju, jie tersia scope'a */
        public static int number1;
        public static int number2;
        public static int result;

        /* Main'e turi buti kuo taip pat kuo maziau siuksliu, kintamuju 
            Realiai vien funkcijos, is kuriu pavadinimu galima butu matyti 
            kas vyksta programoje, kaip kas po ko eina
        */
        static void Main(string[] args)
        {
            // Tokiu irgi nereiketu, geriau sudeti i kokia intro funkcija, pvz. Print_intro(), kurioje visi paaiskinimai vyktu
            Console.WriteLine("Hello, For skaiciuotuvas!");
            
            // Inicijuojame musu jau aprasyta strukturos sablona, vietoje globaliu kintamuju
            user_inputs user_input = new user_inputs;

            /* Kitas etapas sugalvoti kaip perduoti kintamuosius, kad butu aiskiau ir ne painu
                Galima perduoti jos ref i kiekviena funkcija, arba daryti funkcijos, kurios grazintu
                reiksmes.

                pvz.: 
                    get_user_input(ref user_input) ----> Sios funkcijos viduje per user_input sudedame reiksmes
                    Arba user_input = get_user_input();  ----> funkcija grazina ta pacia struktura

                    Kai per ref perduodame reiksmes, reiktu max per kelis sluoksnius tai daryti, pvz
                    func1(ref user_input) {

                        func2(ref user_input) // kuo daugiau tokiu ejimu gilyn su ref, tuo painiau, reiketu naudoti return reiksmes 

                        user_input.a = kazkokia_funkcija()
                        user_input.b = kazkokia_kita_funkcija()
                    }
            */

            // sukuriame ir iskvieciame intro funkcija, apie kuria jau rasiau
            print_intro();

            // galim sukurti kita funkcija, kurioje duodame pasirinkti programos zingsnius: daugyba, dalyba, etc...
            get_user_input(ref user_input.a, ref user_input.b);

            /*
                Tai sakykime kad iki sio zingsnio jau turim duomenu struktura, isspausdinome paaiskinimo teksta, bei 
                nuskaiteme vartotojo ivestis
            */

            /* Kita funkcija, kurioje apskaiciuojame ivestis 
            */
            user_input.result = calculate_inputs(user_input.a, user_input.b, user_input.action);

            /* Apskaiciavom pirmus zingsnius, dabar galime deti vel koki paaiskinima ka toliau daryti nori
                ir jei testu skaiciavima su rezultatu, toliau testume, o jei is naujo skaiciuoti noretu, tai viska ka 
                virsuj kaip pavizdi apraseme galima butu ideti i while cikla, kol action nelygus kazkam tol testi skaiciavima. */


            
        }
        
    get_user_input(ref int a, ref int b) {
        a = Console.Readline();
        b = Console.Readline();
    }

    calcualte_inputs(int a, int b, int action) {
        switch (action)
            case 1:
                return a + b;
            case 2: 
                return a / b;
            case 3:
                return a * b
            etc ...
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
            var isInput2Number = int.TryParse(input2, out int choice2);

            switch (choice2)
            {   
                /* Cia kartojasi dalykai, reiktu i viena funkcija ideti ir ta funkcija kvietineti*/
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

        public static int ContinueWithResult(int number1, int number2)
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
                        ContinueWithResult(number1, number2);
                    }
                    return ContinueWithResult(number1, number2);
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