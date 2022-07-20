namespace P021_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, List!");
            //Console.WriteLine("Didesnis Uz Didziausia:", DidesnisUzDidziausia(lst));



            List<string> stringSarasas = new List<string> { "zodis1", "zodis2", "......" }; //list of strings
            List<int> intSarasas = new List<int> { 1, 44, 33, 44, 5 };

            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };

            

            Console.WriteLine(String.Join(", ", automobiliai));


            automobiliai[1] = "Subaru";
            Console.WriteLine(String.Join(", ", automobiliai));
            Console.WriteLine("   " + automobiliai[2][1]);
            Console.WriteLine("   " + automobiliai[2]);
            Console.WriteLine("   " + automobiliai[2].Length);

            Console.WriteLine("automobiliu kiekis   " + automobiliai.Count);
            Console.WriteLine("Listo talpa   " + automobiliai.Capacity);

            automobiliai.Add("BMW");
            Console.WriteLine("Listo talpa   " + automobiliai.Capacity);



            //Metodai


            //prideti elementa i gala
            automobiliai.Add("Citroen");
            Console.WriteLine(String.Join(", ", automobiliai));

            //prideti daug elementu i gala

            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobiliai.AddRange(daugiauAutomobiliu);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis   " + automobiliai.Count);
            Console.WriteLine("automobilis nr.5 " + automobiliai[5]);

            //isvalyti lista

            //automobiliai.Clear();
            //Console.WriteLine("isvalyta" + string.Join(", ", automobiliai));

            //istrinti elementa
            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis   " + automobiliai.Count);
            Console.WriteLine("automobilis nr.5 " + automobiliai[5]);


            //iterpimas
            automobiliai.Insert(2, "BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis   " + automobiliai.Count);
            Console.WriteLine("automobilis nr.5 " + automobiliai[5]);

            //paieska
            Console.WriteLine("--------------------");

            bool arYraVw = automobiliai.Contains("VW");
            Console.WriteLine("Ar yra VW" + arYraVw);
            bool arYraBmw = automobiliai.Contains("BMW");
            Console.WriteLine("Ar yra BMW" + arYraBmw);

            //rikiavimas
            Console.WriteLine("--------------------");
            automobiliai.Sort();
            Console.WriteLine(string.Join(", ", automobiliai));


            automobiliai.Sort((x,y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobiliai));


            //paieska
            automobiliai.Add("VW");
            Console.WriteLine(string.Join(", ", automobiliai));
            string pirmasKurYraV = automobiliai.Find(x => x.Contains("V"));
            Console.WriteLine("pirmas automobilis kur yra V " +pirmasKurYraV);
            List<string> visiKurYraV = automobiliai.FindAll(x => x.Contains("V"));

            Console.WriteLine(string.Join(", ", visiKurYraV));
            


            string[] automobiliuMasyvas = automobiliai.ToArray();
            int[] intMasyvas = new int[] { 1, 2, 3, 4, 5 };
            List <int> skaiciai = intMasyvas.ToList();





            List<int> lst = new List<int> { 5, 1, 6, 8, 7 };
            lst.Add(9);
            lst.Sort();
            Console.WriteLine($"Didesnis uz didziausia: {lst[lst.Count - 1]}");




        }
        //UZDUOTYS-----------------------------------------------

        //       DIDŽIAUSIAS SĄRAŠE
        //Duotas vienmatis sveikų skaičių sąrašas.
        //Parašykite programą, kuri suranda didžiausią skaičių saraše
        //{ 5, 1, 6, 8, 7 }

        //   rezultatas: 8
        public static int Didziausias(List<int> lst)
        {
            lst.Sort();


            //List<int> numbers = new List<int> { 5, 1, 6, 8, 7 };
            //Console.WriteLine("skaiciu kiekis " + numbers.Count);
            //numbers.Sort();
            //Console.WriteLine("didziausias " + numbers[numbers.Count - 1]);



            return lst[lst.Count -1];
        }


        // DIDESNIS UŽ DIDŽIAUSIĄ
        //Duotas vienmatis sveikų skaičių sąrašas.
        //Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

        //pvz:
        //{ 5, 1, 6, 8, 7 }
        // rezultatas:  5, 1, 6, 8, 7, 9

        public static int DidesnisUzDidziausia(List<int> lst)
        {
            lst = new List<int> { 5, 1, 6, 8, 7 };
            lst.Add(9);
            lst.Sort();
            Console.WriteLine("Didesnis uz didziausia:", lst[lst.Count - 1]);            
            return lst[lst.Count - 1];

        }

        public static List<int> DidesnisUzDidziausia2(List <int> lst)
        {
            var max = Didziausias(lst);
            lst.Add(max + 1);
            return lst;
        }
    }
}