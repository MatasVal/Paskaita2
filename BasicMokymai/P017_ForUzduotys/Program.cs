using System.Text;

namespace P017_ForUzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For uzduotys!");

            //ReadIntNumber();
            //Console.WriteLine("iveskite skaiciu:");
            //var skaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("iveskite laipsni:");
            //var laipsnis = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("rezultatas" + PakeltiLaipsniu(skaicius, laipsnis));

            //SkaiciuTrikampis();
            SkaiciuotuvasMenu();
        }
        /*
        
        UŽDUOTIS 1.
      Sukurti metodą ReadIntNumber,
      kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
      Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
      įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
      neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
      (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
        
        public static void ReadIntNumber()
        {
            Console.WriteLine("Iveskite sveikaji skaiciu:");
            
            bool arSkaiciusTeisingas = false;
            var skaicius = Console.ReadLine();

            while (!arSkaiciusTeisingas)
            {           
               
               arSkaiciusTeisingas = Int32.TryParse(skaicius, out _);

                if (arSkaiciusTeisingas==false)    
                {
                    Console.WriteLine("Ivestas blogas skaicius, bandykite dar karta:");
                    skaicius = Console.ReadLine();
                }                
            }
            Console.WriteLine($"Skaicius: {skaicius}");
        }
        
        Sukurti metodą IntegerToBinary,
        kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
        2 --> 10
        7 --> 111
        45 --> 101101
        
        public static string IntegerToBinary(int sk)
        {
            string binSk = "";
            while (sk>0)
            {
                binSk = sk % 2 + binSk;
                sk /= 2;
            }
            return binSk;
        }
        
        Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
      laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
      kelsime, antras laipsnis, kuriuo pakelti.
      NB! kai laipsnis 0 o skaičius > 0 gąžinama 1
      NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
      NB! kai laipsnis = 1 gąžinamas tas pats skaičius
        

        public static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {                 

            if(laipsnis==0 && skaicius >0)
            {
               return 1;
            }
            if (skaicius == 0 && laipsnis == 0)
            {
                return 0;
            }
            if (laipsnis == 1)
            {
                return skaicius;
            }


            var rezultatas = skaicius;

            for (int i = 1; i < laipsnis; i++)
            {
                rezultatas = rezultatas * skaicius;
            }
            return rezultatas;

            Console.WriteLine($"rezultatas: {rezultatas}");
        }

         
        Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */
        /* 3 UZDUOTIS
        public static string SkaiciuTrikampis(string trikampis)
        {

            Console.WriteLine("Iveskite skaiciu nuo 1 iki 9:");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i == skaicius; i++)
            {
                StringBuilder sb = new StringBuilder(trikampis);

                while (skaicius >9 || skaicius < 1)
                {
                    Console.WriteLine("Skaicius neteisingas, bandykite vel:");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }

                trikampis = trikampis + skaicius; 

                Console.WriteLine(sb.ToString());
            }

            return trikampis;


        }
        */
        public static void SkaiciuTrikampis()
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 9:");
            var builder = new StringBuilder();
            var input = Console.ReadLine();
            var arSkaicius = int.TryParse(input, out int skaicius);
            for (int i = 0; i <= skaicius; i++)
            {
                while (skaicius > 9 || skaicius < 1)
                {
                    Console.WriteLine("Skaicius neteisingas, bandykite vel:");
                    input = Console.ReadLine();
                    arSkaicius = int.TryParse(input, out skaicius);
                }
                builder.Append(skaicius);
                Console.WriteLine(builder.ToString());
            }
        }

        /*4 UZDUOTIS
        Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       jeigu įveda netinkamą skaičių
       prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
        */

        /*5 UZDUOTIS
       Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
       Programa turi grąžinti atitinkamą statųjį trikampį.
       1
       22
       333
       4444
       55555
         */

        //6 UZDUOTIS

        //--------------------------------------------------------------------
        //gerai isspresta uzduotis
        private static int SkaiciausTikrinimas(string? txt) => int.TryParse(txt, out int num) == false ? 0 : num;
               
        private static void PenktaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(skaicius);
                Console.WriteLine(sb.ToString());
            }

            for (int i = skaicius; i >= 1; i--)
            {
                sb.Remove(0, 1);
                Console.WriteLine(sb.ToString());
            }

        }
        //--------------------------------------------------------------------

        /*7 UZDUOTIS
         *  Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
      (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
      Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
      1
      22
      333
      4444
      333
      22
      1
         */
        /* 8 UZDUOTIS    
----------------------------

Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> .......
programa turi paprašyti nurodyti skaičių ir grupių kiekį

naudokite for ir StringBuilder
        */

        //--------------------------------------------------------------------
        //gerai isspresta uzduotis
        private static void SkaiciuEile(string input, int input2)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input2; i++)
            {
                Console.Write("->");
                sb.Append(input);
                Console.Write(sb);
            }

        }
        //--------------------------------------------------------------------

        /*9 UZDUOTIS
------------------------

2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
15 X 1 = 15                                                                                                   

15 X 2 = 30                                                                                                  

15 X 3 = 45                                                                                                   

15 X 4 = 60                                                                                                  

15 X 5 = 75                                                                                                   

15 X 6 = 90                                                                                                  

15 X 7 = 105                                                                                                 

15 X 8 = 120                                                                                                 

15 X 9 = 135                                                                                                 

15 X 10 = 150
         */

        //--------------------------------------------------------------------
        /*gerai isspresta uzduotis
        Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
        var sb = new StringBuilder();
 
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius* i);
        Console.WriteLine(sb);
                sb.Clear();
            }
        */
        //--------------------------------------------------------------------

        /*10 UZDUOTIS
    ----------------------

    Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
    1. Sudetis
    2. Atimtis
    3. Daugyba
    4. Dalyba”
    Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
    o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
    “1
    15
    45
    Rezultatas: 60
    1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
    Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
    Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
    BONUS1: Iskelkite operacijas i metodus
    BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
    Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
    BONUS3: Parasyti unit testus uztikrinant operaciju veikima
    BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
         */
        public static void SkaiciuotuvasMenu()
        {
            Console.WriteLine("1.Nauja operacija\n2.Testi su rezultatu\n3.Iseiti");
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out int choice);

            switch (choice)
            {
                case 1:
                    SubMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    while (choice > 3 || choice < 1)
                    {
                        Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                        input = Console.ReadLine();
                        SkaiciuotuvasMenu();
                    }
                    break;
            }        
                       
        }


        public static void SubMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis\n2. Atimtis\n3. Daugyba\n4. Dalyba");

            var input2 = Console.ReadLine();
            var isNumber2 = int.TryParse(input2, out int choice2);

            switch (choice2)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
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
        }

        /*11 UZDUOTIS
         * Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
    jeigu įveda netinkamą skaičių
    prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
    7
    77
    777
    7777
    77777
    777777
    7777777
    777777
    77777
    7777
    777
    77
    7
         */

        /*12 UZDUOTIS
    ----------------------
    4. Sukurkite programa, kuri atspausdintu sia forma:

        *
       *** 
      *****
     *******
    ********* 
     *******
      *****
       ***
        * 
         */






        /*
         * 1.Parasykite programa, kuri atspausdintu sia figura pvz:
            1
            01
            101
            0101
            10101
         * */



        /*2. 
         * Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. Naudoti tik ciklus ir matematines operacijas.
Visi kintamieji yra integer tipo. Pvz:
            Ivedam- 12345 (int)
            Rezultatas-54321 (int)
         */


    }
}