namespace P002_TowerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.

            Console.WriteLine("1. Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.");

            var tuscias = "       |      ";
            var du      = "      #|#     ";
            var keturi  = "     ##|##    ";
            var sesi    = "    ###|###   ";
            var astuoni = "   ####|####  ";

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias,tuscias,tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", du,tuscias,tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", keturi,tuscias,tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", sesi,tuscias,tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", astuoni,tuscias,tuscias);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");
            
            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();


            //2. Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi

            Console.WriteLine("2. Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", astuoni, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", sesi, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", keturi, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", du, tuscias, tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi

            Console.WriteLine("3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //4. Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi

            Console.WriteLine("4. Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("5eil.{0}{1}{2}", astuoni, astuoni, astuoni);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi

            Console.WriteLine("5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, du);
            Console.WriteLine("5eil.{0}{1}{2}", astuoni, sesi, keturi);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi

            Console.WriteLine("6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", du, tuscias, du);
            Console.WriteLine("5eil.{0}{1}{2}", keturi, sesi, keturi);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //7. Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi

            Console.WriteLine("7. Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, keturi, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, keturi, tuscias);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, keturi, tuscias);
            Console.WriteLine("4eil.{0}{1}{2}", du, keturi, du);
            Console.WriteLine("5eil.{0}{1}{2}", keturi, keturi, keturi);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //8. Į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi

            Console.WriteLine("8. Į 3stulp sudėkite teisingą piramidę. 1 stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, du);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, keturi);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, sesi);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, astuoni);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //9. Pakeiskite visų elementų dizainą iš # į ", išveskite Tower of Hanoi

            Console.WriteLine("9. Pakeiskite visų elementų dizainą iš # į \", išveskite Tower of Hanoi");

            Console.WriteLine();

            du = du.Replace("#", "\"");
            keturi = keturi.Replace("#", "\"");
            sesi = sesi.Replace("#", "\"");
            astuoni = astuoni.Replace("#", "\"");

            Console.WriteLine("1eil.{0}{1}{2}", tuscias, tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, du);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, keturi);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, sesi);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, astuoni);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");
                    
            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //10. Paprašykite naudotojo nupiešti 1 stulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("10. Paprašykite naudotojo nupiešti 1 stulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute");

            Console.WriteLine();
            Console.WriteLine("Prašome nupiešti 1 stulpelio 1 eilutę:");
            
            Console.WriteLine("1eil.      {0}     {1}{2}", Console.ReadLine(), tuscias, tuscias);
            Console.WriteLine("2eil.{0}{1}{2}", tuscias, tuscias, du);
            Console.WriteLine("3eil.{0}{1}{2}", tuscias, tuscias, keturi);
            Console.WriteLine("4eil.{0}{1}{2}", tuscias, tuscias, sesi);
            Console.WriteLine("5eil.{0}{1}{2}", tuscias, tuscias, astuoni);
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();
        }
    }
}