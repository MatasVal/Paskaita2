using System.Collections.Generic;

namespace P023_Dictionaries
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dictionaries!");
            DictionaryPavyzdys();
        }

        public static void DictionaryPavyzdys()
        {
            //Zodyno/Dictionary deklaravimas
            Dictionary<string, float> kainyZodynas = new Dictionary<string, float>(3);
            var kainyKintamasisZodynas = new Dictionary<string, float>();

            Dictionary<string, int> miestai = new Dictionary<string, int>
            {
                { "Vilnius", 7 },
                { "Kaunas", 6 },
                { "Siauliai", 8 },
                { "Jonava", 6 }
            };

            Dictionary<string, string> zodziuReiksmes = new Dictionary<string, string>()
            {
                { "Macnus", "stipraus, astraus skonio" },
                { "Unaravas", "pasiputes, arogantiskas" },
                { "Ceckavot", "smulkiai pjaustyti" },
                { "Bimbineti", "leisti laika be jokio tikslo" },
                { "Katras", "kuris is keliu galimu pasirinkimu" }
            };

            var varduZodynas = new Dictionary<int, string>()
            {
                { 1, "Andrius" },
                { 2, "Ieva" },
                { 3, "Aiste" },
                { 4, "Ieva" },
                { 5, "Eugenijus" }
            };

            //Zodyno/Dictionary skaitymas
            Console.WriteLine($"Vilnius:{miestai["Vilnius"]} Kaunas: {miestai["Kaunas"]}");
            var miestoPavadinimoIlgis = miestai["Vilnius"];
            Console.WriteLine($"Kintamojo ilgis:{miestoPavadinimoIlgis}");

            //Zodyno/Dictionary pildymas. KeyValuePair
            miestai.Add("Klaipeda", 8);
            Console.WriteLine($"Klaipeda: {miestai["Klaipeda"]}");
            miestai["Silute"] = 6;
            Console.WriteLine($"Silute: {miestai["Silute"]}");


            //Zodyno/Dictionary skaitymas
            foreach(KeyValuePair<string, int> miestas in miestai) //vietoj "KeyValuePair<string, int>" gali buti "var"
            {
                Console.WriteLine(miestas);
            }

            foreach (KeyValuePair<string, int> miestas in miestai) 
            {
                Console.WriteLine(miestas.Key);
            }
            foreach (KeyValuePair<string, int> miestas in miestai) 
            {
                Console.WriteLine(miestas.Value);
            }
            foreach (var miestas in miestai)
            {
                Console.WriteLine("Raktas = {0}, Reiksme = {1}", miestas.Key, miestas.Value);
            }
            for (int i = 1; i <= varduZodynas.Count; i++)
            {
                Console.WriteLine($"{varduZodynas[i]}");
            }

            //Zodyno/Dictionary elemento/iraso validavimas
            if (miestai.TryGetValue("Klaipeda", out int miestoSkaicius))
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }
            else
            {
                Console.WriteLine("Neradome iraso");
            }
                      

            if(!miestai.ContainsKey("Klaipeda"))
            {
                Console.WriteLine("Neradome iraso");
                
            }
            else
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }


            //Zodyno/dictionary ValueCollection
            Dictionary<string, int>.ValueCollection miestuReiksmes = miestai.Values;

            foreach (int miestoPavadinimoReiksme in miestuReiksmes)
            {
                Console.WriteLine("Reiksme = {0}", miestoPavadinimoReiksme);
            }

            //Zodyno/dictionary KEYCollection
            Dictionary<string, int>.KeyCollection miestuRaktai = miestai.Keys;
            var miestuRaktaiSuVar = miestai.Keys;

            foreach (string miestoPavadinimoRaktas in miestuRaktai)
            {
                Console.WriteLine("Raktas = {0}", miestoPavadinimoRaktas);
            }

            //Zodyno/Dictionary isemimas
            varduZodynas.Remove(2);
            //for (int i = 1; i <= varduZodynas.Count; i++)
            //{
            //    Console.WriteLine($"{varduZodynas[i]}");
            //}

            foreach (var vardas in varduZodynas)
            {
                Console.WriteLine("Vardas = {0}", vardas.Value);
            }


            if (!varduZodynas.ContainsKey(2))
            {
                Console.WriteLine("Neradome iraso");

            }
            else
            {
                Console.WriteLine($"Vardas: {varduZodynas[2]}");
            }

            //Zodyno isvalymas
            var skaiciuZodynas = new Dictionary<int, int>
            { 
                {1, 1},
                {2, 2},
                {3, 3},
                {4, 4},
                {5, 5}


            };
            skaiciuZodynas.Clear();

            if (skaiciuZodynas.Count == 0)
            {
                Console.WriteLine("Irasu nerasta");

            }
            else
            {
                Console.WriteLine("zodynas turi daugiau nei 0 irasu");
            }

        }

    }
}