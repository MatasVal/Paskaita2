using System;
using System.Collections.Generic;

namespace P021_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists!");
            List<string> stringSarasas = new List<string> { "zodis1", "zodis2", "........" };

            List<int> intSarasas = new List<int> { 1, 22, 33, 44, 5 };

            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };
            Console.WriteLine(string.Join(", ", automobiliai));


            Console.WriteLine(string.Join(", ", automobiliai));

            automobiliai[1] = "Subaru";
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("  " + automobiliai[2][1]);
            Console.WriteLine("  " + automobiliai[2]);
            Console.WriteLine("  " + automobiliai[2].Length);

            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("Listo talpa " + automobiliai.Capacity);

            automobiliai.Add("BMW");
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("Listo talpa " + automobiliai.Capacity);

            //Console.WriteLine(automobiliai[6]);

            //Metodai
            //prideti elementa i gala
            automobiliai.Add("Citroen");
            Console.WriteLine(string.Join(", ", automobiliai));

            //prideti daug elementu i gala
            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobiliai.AddRange(daugiauAutomobiliu);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //isvalyti lista
            //automobiliai.Clear();
            //Console.WriteLine("isvalyta " + string.Join(", ", automobiliai));
            //Console.WriteLine("automobiliu kiekis " + automobiliai.Count);

            //istrinti elementa
            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //iterpimas
            Console.WriteLine("-------------------------");
            automobiliai.Insert(2, "BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //paieska
            Console.WriteLine("-------------------------");
            bool arYraVw = automobiliai.Contains("VW");
            Console.WriteLine("Ar yra VW? " + arYraVw);
            bool arYraBmw = automobiliai.Contains("BMW");
            Console.WriteLine("Ar yra BMW? " + arYraBmw);

            //rikiavimas
            Console.WriteLine("-------------------------");
            automobiliai.Sort();
            Console.WriteLine(string.Join(", ", automobiliai));

            automobiliai.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobiliai));


            Console.WriteLine("-------------------------");
            intSarasas.Sort();
            Console.WriteLine(string.Join(", ", intSarasas));
            intSarasas.Sort((x, y) => y - x);
            Console.WriteLine(string.Join(", ", intSarasas));


            //paieska
            Console.WriteLine("-------------------------");
            automobiliai.Add("VW");
            Console.WriteLine(string.Join(", ", automobiliai));

            string pirmasKurYraV = automobiliai.Find(x => x.Contains("V"));
            Console.WriteLine("Pirmas automobilis kur yra V " + pirmasKurYraV);
            List<string> visiKurYraV = automobiliai.FindAll(x => x.Contains("V"));
            Console.WriteLine(string.Join(", ", visiKurYraV));

            List<int> visiVirs6 = intSarasas.FindAll(x => x > 6);
            Console.WriteLine(string.Join(", ", visiVirs6));



            string[] automobiliuMasyvas = automobiliai.ToArray();

            int[] intMasyvas = new int[] { 1, 2, 3, 4, 5 };
            //List<int> skaiciai = intMasyvas.ToList();








        }

        /* 1. DIDŽIAUSIAS SĄRAŠE
     Duotas vienmatis sveikų skaičių sąrašas. 
     Parašykite programą, kuri suranda didžiausią skaičių saraše
     { 5, 1, 6, 8, 7 }

     rezultatas:  8
     */
        public static int DidziausiasSarase(List<int> lst)
        {
            int max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }
            return max;
        }
        public static int DidziausiasSarase_SuSort(List<int> lst)
        {
            lst.Sort();
            return lst[lst.Count - 1];
        }


        /* 2. DIDESNIS UŽ DIDŽIAUSIĄ
      Duotas vienmatis sveikų skaičių sąrašas. 
      Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

      pvz:
      { 5, 1, 6, 8, 7 }
      rezultatas:  5, 1, 6, 8, 7, 9

      */
        public static List<int> DidesnisUzDidziausia(List<int> lst)
        {
            var max = DidziausiasSarase(lst);
            lst.Add(max + 1);
            return lst;
        }

        public static List<int> DidesnisUzDidziausia_SuSort(List<int> lst)
        {
            List<int> tmp = new List<int>();
            tmp.AddRange(lst);
            //List<int> tmp = lst;


            var max = DidziausiasSarase_SuSort(tmp);
            lst.Add(max + 1);
            return lst;
        }



        /*  3. MAŽIAUSIAS NEREIKALINGAS
        Duotas vienmatis sveikų skaičių sąrašas. 
        Parašykite programą, kuri iš sąrašo pašalina mažiausią skaičių

        pvz:
        { 5, 1, 6, 8, 7 }
        rezultatas:  5, 6, 8, 7
        */


        /* 4. ## DU PO DU ##
      Duotas vienmatis sveikų skaičių sąrašas. 
      Parašykite programą, kuri skaičiaus 2 įterpia dar vieną skaičių 2

      pvz: 
        { 5, 1, 2, 6, 8, 7 }
      rezultatas:  { 5, 1, 2, 2, 6, 8, 7 }
      */



        /* 5. ## DIDESNIS ŠALIA ##
       Duotas vienmatis sveikų skaičių sąrašas. 
       Parašykite programą, kuri prie kiekvieno skaičiaus sąraše iš dešinės pusės pideda vienetu didesnį skaičių

       pvz:
         { 5, 1, 6, 8, 7 }
       rezultatas:  {  5, 6, 1, 2, 6, 7, 8, 9, 7, 8}
       */









    }
}