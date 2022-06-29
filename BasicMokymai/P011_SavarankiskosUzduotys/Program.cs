namespace P011_SavarankiskosUzduotys
{
    public class Program
    {
        //public static string Tekstas = ""; //nera skliausteliu tai reiskia cia yra globalus kintamasis


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");

            Console.WriteLine("Iveskite teksta:");
           
            string tekstas = Console.ReadLine();


            Console.WriteLine($"Tarpu kiekis yra: {TarpuKiekis(tekstas)}");
            Console.WriteLine($"Teksto ilgis yra: {TekstoIlgis(tekstas)}");
            Console.WriteLine($"Zodziu kiekis yra: {ZodziuKiekis(tekstas)}");
            Console.WriteLine($"Tarpu kiekis gale yra: {TarpuKiekisGale(tekstas)}");
            Console.WriteLine($"Tarpu kiekis pradzioje yra: {TarpuKiekisPradzioje(tekstas)}");

            //Console.WriteLine($"Pradzioje yra tarpu: {TarpuKiekisPradziojeIrGale(tarpuSkPradzioje)}, gale yra tarpu: {}");
            Console.WriteLine($"Ar yra mokausi: {ArYraZodisMokausi(tekstas)}"); 

        }

        //private static void IsvestiIvestaTeksta()
        //{
        //    Console.WriteLine($"ivestas tekstas yra {Tekstas}");
        //}



        // 4 Uzduotis
        /*
         Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
- Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
- Main metode į ekraną išveskite tarpų kiekį
Pvz:
> Iveskite teksta:
_ as mokausi programuoti
> Tarpu kiekis yra: 2
        */



        public static int TarpuKiekis(string tekstas)
        {
            return tekstas.Length - tekstas.Replace(" ", "").Length;
        }


        // 5 Uzduotis
        /*
         Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
- Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
_ ' as mokausi '
> Teksto ilgis yra: 10
        */
         public static int TekstoIlgis(string tekstas)  
        {
            return tekstas.Trim().Length;
        }



        // 6 Uzduotis

        /*
        Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
   - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
   - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
   - Main metode į ekraną išveskite žodžių kiekį
   Pvz:
   > Iveskite teksta:
   _ as mokausi programuoti
   > Zodziu kiekis yra: 3
            */

        public static int ZodziuKiekis(string tekstas)
        {
            return tekstas.Length - tekstas.Replace(" ", "").Length + 1;
        }


        // 7 Uzduotis

        /*
    Parašykite programą kurioje vienas metodas.
   - Naudotojo paprašome įvesti betkokį tekstą Main metode.
   - Metodas grąžina tarpų kiekį teksto gale
   - Main į ekraną išveda rezultatą
   Pvz:
   > Iveskite teksta:
   _ ' as mokausi      '
   > Gale yra tarpų: 6
        */

        public static int TarpuKiekisGale(string tekstas)
        {
            return tekstas.Length - tekstas.TrimEnd().Length;
        }



        // 8 Uzduotis

        /*
        Parašykite programą kurioje vienas metodas.
       - Naudotojo paprašome įvesti betkokį tekstą Main metode.
       - Metodas grąžina tarpų kiekį teksto pradžioje
       - Main į ekraną išveda rezultatą
       Pvz:
       > Iveskite teksta:
       _ ' as mokausi      '
       > Pradžioje yra tarpų: 1
            */

        public static int TarpuKiekisPradzioje(string tekstas)
        {
            return tekstas.Length - tekstas.TrimStart().Length;
        }


        // 9 Uzduotis

        /*
    Parašykite programą kurioje vienas metodas.
  - Naudotojo paprašome įvesti betkokį tekstą Main metode.
  - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
    <hint> naudoti out
  - Main į ekraną išveda rezultatą
  Pvz:
  > Iveskite teksta:
  _ ' as mokausi      '
  > Pradžioje yra tarpų: 1
  > Gale yra tarpų: 6
    */
        public static int TarpuKiekisPradziojeIrGale(string tekstas, out int tarpuSkPradzioje)
        {
            tarpuSkPradzioje = tekstas.Length - tekstas.TrimStart().Length;
            return tekstas.Length - tekstas.TrimEnd().Length;
           
        }                     //kodel viena reiksme vedama per return o kita kitaip?




        // 10 Uzduotis

        /*
        Parašykite programą kurioje yra vienas metodas.
    - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
    - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
    - Main metode į ekraną išveskite metodo darbo rezultatą
    Pvz:
    > Iveskite teksta:
    _ as mokausi programuoti
    > 'a' raidžių kiekis yra: 3
        */

        public static int KiekYraRaidziuA(string tekstas)
        {
            return tekstas.Length - tekstas.Replace("a", "").Length;
        }


        //11 Uzduotis
        /*
         Parašykite programą kurioje vienas metodas.
    - Naudotojo paprašome įvesti betkokį tekstą Main metode.
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz:
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip
         */

        public static string ArYraZodisMokausi(string tekstas)
        {
            var yraArNe = tekstas.Contains("mokausi");

            string taipArNe = "";
            
             if (yraArNe)
            {
                taipArNe = "Taip";
            }
            else
            {
                taipArNe = "Ne";
            }

            return taipArNe;
        }

        /* 11A Uzduotis
               
          
        Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip

    Pvz: 
    > Iveskite teksta:
    _ ' as_labai_mokausi_programuoti     '
    > Ar yra mokausi: Ne
         */

        public static string ArYraZodisMokausiAAA(string tekstas)
        {
            var yraArNe = tekstas.Contains("mokausi");

            string taipArNe = "";

            if (yraArNe)
            {
                taipArNe = "Taip";
            }
            else
            {
                taipArNe = "Ne";
            }



            return taipArNe;
        }


        //12 Uzduotis
        /*          
          
         Parašykite programą kurioje yra vienas metodas.
      - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
      - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
      - Main metode į ekraną išveskite metodo darbo rezultatą
      Pvz:
      > Iveskite teksta:
      _ as mokausi programuoti
      > 'a' raides vieta yra: 0

         */

        public static void ARaidesVieta();



    }



}