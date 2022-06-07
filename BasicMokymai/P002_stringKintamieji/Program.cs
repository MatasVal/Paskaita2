namespace P002_stringKintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String (tekstinio) tipo kintamieji");
            string kintamasis = "Hello World";
            Console.WriteLine(kintamasis);

            var stringKintamasis = "bet koks tekstas";
            string tuscias = "";
            string nulas = null;
            string Laisvaerdve = "    ";

            string tekstas = "";

            string konkatinacija = stringKintamasis + kintamasis;
            Console.WriteLine(konkatinacija);
            string kompozicija = string.Format("{0}", stringKintamasis);
            string interpoliacija = $"{stringKintamasis}";

            kintamasis = "tekstas betkoks";
            Console.WriteLine(kintamasis);






        }
    }
}