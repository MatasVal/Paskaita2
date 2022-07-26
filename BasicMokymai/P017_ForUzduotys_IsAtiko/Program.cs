namespace P017_ForUzduotys_IsAtiko
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For uzduotys!");
            Console.WriteLine("Iveskite skaiciu");
            var skaicius = ReadIntNumber();
            Console.WriteLine("Iveskite laipsni");
            var laipsnis = ReadIntNumber();


            Console.WriteLine("rezultatas " + PakeltiLaipsniu(skaicius, laipsnis));
        }

        /*
      UŽDUOTIS 1.
      Sukurti metodą ReadIntNumber, 
      kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
      Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
      įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
      neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
      (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
      */
        public static int ReadIntNumber()
        {
            Console.WriteLine("Įveskite sveikąjį skaičių");

            string skaiciusStr = string.Empty;
            bool arSkaiciusTeisingas = false;
            int skaicius = 0;
            while (!arSkaiciusTeisingas)
            {
                skaiciusStr = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaiciusStr, out skaicius);
                if (!arSkaiciusTeisingas) Console.WriteLine("Ivestas neteisingas skaicius, bandykite dar");
            }
            Console.WriteLine($"Ivestas skaicius {skaiciusStr}");
            return skaicius;
        }


        /*
       Sukurti metodą IntegerToBinary, 
       kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
       2 --> 10
       7 --> 111
       45 --> 101101 
       */
        public static string IntegerToBinary(int integerNumber)
        {
            string binaryNumber = string.Empty;
            while (integerNumber > 0)
            {
                binaryNumber = integerNumber % 2 + binaryNumber;
                integerNumber = integerNumber / 2;
            }
            return binaryNumber;
        }


        /*
      Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
      laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
      kelsime, antras laipsnis, kuriuo pakelti.
      NB! kai laipsnis 0 o skaičius > 0 gąžinama 1
      NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
      NB! kai laipsnis = 1 gąžinamas tas pats skaičius
      */
        public static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {

            if (laipsnis == 0 && skaicius > 0)
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
        }

        /* SkaiciuTrikampis
        Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą). 
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */

        /* SkaiciuPiramide
        Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą)
        Metodas turi grąžinti atitinkamą piramide su tiek skaičių centre koks skaičius įvestas.
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
        /*
       Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
       (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
       Metodas turi grąžinti atitinkamą statųjį trikampį.
       1
       22
       333
       4444
       55555
       */

        /*
      Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
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
    }
}