namespace DNR_inzinerija
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var pradinisDNR = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            Console.WriteLine($"DNR grandinė: {pradinisDNR}");
            Console.WriteLine();
            Meniu(pradinisDNR);
            Console.WriteLine($"Normalizuota grandine: {NormalizavimasGrandines(pradinisDNR)}");
            Console.WriteLine();
            Console.WriteLine($"Ar validi grandine: {ValidacijaGrandines(pradinisDNR)}");
        }

        /*
        Tarkime turime DNR grandinę užkoduotą tekstu var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
        Galimos bazės: Adenine, Thymine, Cytosine, Guanine
          Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
          1. Atlikti DNR grandinės normalizavimo veiksmus:
             - pašalina tarpus.
             - visas raides keičia didžiosiomis.

          2. Atlikti grandinės validaciją
             - patikrina ar nėra kitų nei ATCG raidžių

          3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu

              - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui
              1) normalizuoti grandinę
              2) išeiti iš programos

              - jei grandinė normalizuota arba kai buvo atlikta normalizacija
              1) GCT pakeis į AGG
              2) Išvesti ar yra tekste CAT
              3) Išvesti trečia ir penktą grandinės segmentus(naudoti Substring()).
              4) Išvesti raidžių kiekį tekste(naudoti string composition)
              5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
              6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą
                  (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
              7) Iš grandinės pašalinti pasirinką elementą  
              8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros
                  (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
              9) Gryžti į ankstesnį meniu

        Visoms operacijoms reikalingi testai.
        */

        public static string NormalizavimasGrandines(string pradinisDNR)
        {
            return pradinisDNR.Replace(" ", "").ToUpper();
        }
        public static string ValidacijaGrandines(string pradinisDNR) //istrinti 'atcg' ir '-' ir paziureti ar ilgis yra 0
        {
           var ilgisPasalinusATCG = pradinisDNR.ToUpper().Replace(" ", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Replace("-", "").Length;
           Console.WriteLine($"ilgis: {ilgisPasalinusATCG}");
           return ilgisPasalinusATCG == 0 ? "Validi" : "Nevalidi";
        }
        public static void Meniu(string pradinisDNR)
        {
            Console.WriteLine(@"Kokį veiksmą norite atlikti?

          1. Atlikti DNR grandinės normalizavimo veiksmus
             
          2. Atlikti grandinės validaciją
             
          3. Atlikti veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi)");

            int.TryParse(Console.ReadLine(), out int pasirinkimas0);

            switch (pasirinkimas0)
            {
                case 1: 
                    pradinisDNR = NormalizavimasGrandines(pradinisDNR);
                    break;
                case 2:
                    pradinisDNR = ValidacijaGrandines(pradinisDNR);
                    break;
                case 3:
                    SubMeniu(pradinisDNR);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }

        }
        public static void SubMeniu(string pradinisDNR)
        {

        }

    }
}