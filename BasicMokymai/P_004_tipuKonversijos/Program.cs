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

            //*** Type Conversion Methods
            string konvertuotasString = Convert.ToString(skaiciusInt);//skaicius tapo tesktu
            string konvertuotasString1 = skaiciusInt.ToString();


            long konvertuotasLong = Convert.ToInt64(skaiciusInt);//long yra 64 integer tipas
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);


            //int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis);// luzta nes netelpa


            //darbas su null tipais
            int? skaiciusIntNull = null; //klaustukas kad priiimtu su null
            //long castintasLong5 = (long)skaiciusIntNull; //luzta
            long konvertuotasLong1 = Convert.ToInt64(skaiciusIntNull);//programa neluzta, o grazinama long tipo default reiksme ty 0
            Console.WriteLine($" konvertuotasLong1={konvertuotasLong1}");

            //Parsinimas - skaitmens konvertavimas is teksto

            string skaiciusString = "100";
            string skaiciusDidelisString = "99999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);
            Console.WriteLine($" skaiciusString + 1={skaiciusString + 1}");
            Console.WriteLine($" skaiciusIntParsintas + 1={ skaiciusIntParsintas +1}");

            //int skaiciusIntParsintas = int.Parse(skaiciusDidelisString);
            //int stekstasIntParsintas = int.Parse(tekstas);

            /*
             *  Console.WriteLine("Hello, Tipu konversijos!");
            // Implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; //tipo konversija daroma automatiškai

            var castintasLong2 = (long)skaiciusInt;

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
            //Byte->short->int->long->float->double->decimal

            //Explicit casting
            int castintasInt = (int)skaiciusLong;
            //decimal -> double -> float -> long -> int -> char
            float fl = 5.9f;
            int castintasint1 = (int)fl;
            Console.WriteLine("  i={0}", castintasint1);

            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;
            Console.WriteLine($"  castintasInt2={castintasInt2} ");
            long castintasLong3 = skaiciusRaide;
            //char->ushort->int->uint->long->ulong->float->double->decimal

            //string a = "a";
            //int castintasInt3 = (int)a;

            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($"   castintasInt4={castintasInt4}");

            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($"  castintasInt5={castintasInt5}");


            //*** Type Conversion Methods
            string konvertuotasString = Convert.ToString(skaiciusInt);
            string konvertuotasString1 = skaiciusInt.ToString();
            long konertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            //int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis); //Luzta nes netelpa

            //darbas su nullable tipais
            int? skaiciusIntNull = null;
            //long castintasLong5 = (long)skaiciusIntNull; //Luzta
            long konvertuotasLong1 = Convert.ToInt64(skaiciusIntNull); //programa neluzta, o grąžinama long tipo default reikšmė ty 0
            Console.WriteLine( $"   konvertuotasLong1 = {konvertuotasLong1}");

            //parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "999999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);
            Console.WriteLine($"   skaiciusString + 1 = {skaiciusString + 1}");
            Console.WriteLine($"   skaiciusIntParsintas + 1 = {skaiciusIntParsintas + 1}");

            //int skaiciusIntParsintas1 = int.Parse(skaiciusDidelisString);
            //int tekstasIntParsintas = int.Parse(tekstas);
             * */




        }
    }
}