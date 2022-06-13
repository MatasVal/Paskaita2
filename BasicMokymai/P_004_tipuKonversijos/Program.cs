namespace P_004_tipuKonversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipu konversijos!");
            //Implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;//(long) nebutinas
            long castintasLong1 = skaiciusInt;//tipo konversija daroma automatiskai

            var castintasLong2 = (long)castintasLong; //cia jau reikia

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLong2;
            double skaiciusDouble3 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;
            //Byte>short>int>long>float>double>decimal

            //Explicit casting
            int castintasInt = (int)skaiciusLong;
            //decimal>double>float>long>int>char

            float fl = 5.6f;
            int castintasInt1 = (int)fl;
            Console.WriteLine("    i={0}", castintasInt1);

            char skaiciusRaide = 'a';
            int castintasInt2 = (int)skaiciusRaide;

            Console.WriteLine($"castintasInt2={castintasInt2}");

            long castintasLong3 = skaiciusRaide;
            //char>ushort>int>uint>long>ulong>float>double>decimal

            //string a = "a";
            //int castintasInt3 = (int)a;      //castinimas negalimas, nes string nera skaitmeninis tipas.


            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($"  castintasInt4={castintasInt4}");


            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($" castintasInt5={castintasInt5}"); //LABAI SVARBU!! didesnio i mazesni keiciant kompiuteris gali pradeti daryti klaidas skaiciuojant






        }
    }
}