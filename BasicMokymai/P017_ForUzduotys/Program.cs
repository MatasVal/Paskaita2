using System.Text;

namespace P017_ForUzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For uzduotys!");

            ReadIntNumber();
            Console.WriteLine("iveskite skaiciu:");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite laipsni:");
            var laipsnis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rezultatas" + PakeltiLaipsniu(skaicius, laipsnis));


            var trikampis = "";


            SkaiciuTrikampis(trikampis);
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
        /*
        Sukurti metodą IntegerToBinary,
        kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
        2 --> 10
        7 --> 111
        45 --> 101101
        */
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

        /* 
        Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */

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
    }
}