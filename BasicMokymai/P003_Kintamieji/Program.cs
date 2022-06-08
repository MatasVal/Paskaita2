namespace P003_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Sveiki, kintamieji");
            //Skaiciu kintamieji
            //Sveiku skaiciu kintamieji
            byte mazasSkaicius = 2; //255 max
            short trumpasSkaicius = 2; //32767 max
            int skaicius = 2; //2147483647 max
            int maksimalusIntSkaitmuo = int.MaxValue;
            int minimalusIntSkaitmuo = int.MinValue;

            Console.WriteLine("maksimalusIntSkaitmuo={0}\n minimalusIntSkaitmuo = {1}   ", maksimalusIntSkaitmuo, minimalusIntSkaitmuo);



            long ilgasSkaicius = 2;

            //skaicius = null; //negalima, non nullable

            int? skaiciusKurisGaliButiNull;
            skaiciusKurisGaliButiNull= null;

            Nullable<int> skaiciusKurisGaliButiNull2 = null;

            uint tikTeigiamasSkaicius = 2; //4294967295 "U" padidina reiksmes, unsign? tipas
            //tikTeigiamasSkaicius = -5; taip negalima

            int skaicius5;
            skaicius5 = 5;
            Console.WriteLine(skaicius5);

            Console.WriteLine("Floating point types");

            float maziausiasTrupmeninis = 8.5f;
            var trupmeninisVar = 8.5f;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;


            Console.WriteLine("Loginiai kintamieji");


            Console.WriteLine("char kintamieji");
            char raide = 'n'; //yra sveiko skaitmens tipas, nors atrodo kad talpina raide. integer ar ushort analogas.*/



            //PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
            //• MOKYKLOS PAVADINIMĄ

            var mokyklosPavadinimas = "CodeAcademy";
            var kursoPavadinimas = "CA.NET2";
            var studentuSkaicius = "19";
            var siandienosData = new DateTime(2022, 06, 08);

            Console.WriteLine($"mokyklosPavadinimas - {mokyklosPavadinimas}\nkurso pavadinimas - {kursoPavadinimas}\nstudentu skaicius - {studentuSkaicius}\nsiandienos data - {siandienosData}");

            var kursuPradzia = new DateTime(2022, 05, 30);
            var kursuPabaiga = new DateTime(2022, 12, 26);
            var kursoTrukme = 
            TimeSpan diff = kursuPabaiga - kursuPradzia;
            Console.WriteLine("skirtumas: {0}", diff);



            //Sukurkite tris kintamuosius.tekstinio, sveiko skaitmens ir loginio tipo.
            //Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu

            string tekstas = "tekstas";

            bool
                 var tekstinio





            //Console.WriteLine("CodeAcademy");


            //• KURSO PAVADINIMĄ
            //Console.WriteLine(".NET");

            //var kursoPavadinimas = .NET;


            //• STUDENTŲ SKAIČIŲ
            //Console.WriteLine("19");

            //• ŠIANDIENOS DATĄ
            //Console.WriteLine(DateTime.Now);

            //• VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ 




        }
    }
}