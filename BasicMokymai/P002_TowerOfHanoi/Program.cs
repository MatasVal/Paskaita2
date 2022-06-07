namespace P002_TowerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.
Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi
Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi
Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi
į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi
pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi
paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute */


            var tuscias = "       |      ";
            var du = "      #|#     ";
            var keturi = "     ##|##    ";
            var sesi = "    ###|###   ";
            var astuoni = "   ####|####  ";



            Console.WriteLine("1eil.{0}{1}{2}", tuscias,tuscias,tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", du,tuscias,tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", keturi,tuscias,tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", sesi,tuscias,tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", astuoni,tuscias,tuscias);
            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");

           
            Console.ReadLine();
            Console.WriteLine("------testi-----");
            //kaip isvalyti pirma stulpeli ir isvesti?

            Console.WriteLine("1eil.{0}{1}{2}", astuoni, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", sesi, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", keturi, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", du, tuscias, tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");





        }
    }
}