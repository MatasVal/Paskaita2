namespace TowerOfHanoi_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.

            Console.WriteLine("1. Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.");

            var stul1_eil1 = "       |      ";
            var stul1_eil2 = "      #|#     ";
            var stul1_eil3 = "     ##|##    ";
            var stul1_eil4 = "    ###|###   ";
            var stul1_eil5 = "   ####|####  ";

            var stul2_eil1 = "       |      ";
            var stul2_eil2 = "       |      ";
            var stul2_eil3 = "       |      ";
            var stul2_eil4 = "       |      ";
            var stul2_eil5 = "       |      ";

            var stul3_eil1 = "       |      ";
            var stul3_eil2 = "       |      ";
            var stul3_eil3 = "       |      ";
            var stul3_eil4 = "       |      ";
            var stul3_eil5 = "       |      ";


            Console.WriteLine();

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();


            //2. Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi

            Console.WriteLine("2. Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi");

            Console.WriteLine();

            stul1_eil1 = stul1_eil5;
            stul1_eil2 = stul1_eil4;
            stul1_eil4 = "      #|#     ";
            stul1_eil5 = "       |      ";

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi

            Console.WriteLine("3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi");

            Console.WriteLine();

            stul1_eil1 = stul1_eil2 = stul1_eil3 = stul1_eil4 = stul2_eil1;

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //4. Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi

            Console.WriteLine("4. Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi");

            Console.WriteLine();

            stul1_eil1 = stul1_eil2 = stul1_eil3 = stul1_eil4 = stul2_eil1;
            stul1_eil5 = stul2_eil5 = stul3_eil5 = "   ####|####  ";

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi

            Console.WriteLine("5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            stul2_eil5 = "    ###|###   ";
            stul3_eil4 = "      #|#     ";
            stul3_eil5 = "     ##|##    ";

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi

            Console.WriteLine("6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            stul1_eil4 = stul3_eil4;

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //7. Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi

            Console.WriteLine("7. Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi");

            Console.WriteLine();

            stul2_eil1 = stul2_eil2 = stul2_eil3 = stul2_eil4 = stul2_eil5 = stul3_eil5;

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //8. Į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi

            Console.WriteLine("8. Į 3stulp sudėkite teisingą piramidę. 1 stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi");

            Console.WriteLine();

            stul2_eil1 = stul2_eil2 = stul2_eil3 = stul2_eil4 = stul2_eil5 = stul1_eil4 = stul1_eil5 = stul1_eil1;
            stul3_eil2 = "      #|#     ";
            stul3_eil3 = "     ##|##    ";
            stul3_eil4 = "    ###|###   ";
            stul3_eil5 = "   ####|####  ";


            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}");
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}");
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}");
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}");
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //9. Pakeiskite visų elementų dizainą iš # į ", išveskite Tower of Hanoi

            Console.WriteLine("9. Pakeiskite visų elementų dizainą iš # į \", išveskite Tower of Hanoi");

            Console.WriteLine();

            Console.WriteLine($"1eil.{stul1_eil1}{stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}".Replace("#", "\""));
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}".Replace("#", "\""));
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}".Replace("#", "\""));
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}".Replace("#", "\""));
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();

            //10. Paprašykite naudotojo nupiešti 1 stulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("10. Paprašykite naudotojo nupiešti 1 stulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute");

            Console.WriteLine();
            Console.WriteLine("Prašome nupiešti 1 stulpelio 1 eilutę:");

            stul1_eil1 = Console.ReadLine();

            Console.WriteLine($"1eil.      {stul1_eil1}     {stul2_eil1}{stul3_eil1}");
            Console.WriteLine($"2eil.{stul1_eil2}{stul2_eil2}{stul3_eil2}".Replace("#", "\""));
            Console.WriteLine($"3eil.{stul1_eil3}{stul2_eil3}{stul3_eil3}".Replace("#", "\""));
            Console.WriteLine($"4eil.{stul1_eil4}{stul2_eil4}{stul3_eil4}".Replace("#", "\""));
            Console.WriteLine($"5eil.{stul1_eil5}{stul2_eil5}{stul3_eil5}".Replace("#", "\""));
            Console.WriteLine("      ---1stulp--------2stulp--------3stulp---");

            Console.WriteLine();
            Console.WriteLine("------tęsti------");
            Console.ReadLine();
        }
    }
}