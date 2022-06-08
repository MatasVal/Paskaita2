namespace P003_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, kintamieji");
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
            char raide = 'n'; //yra sveiko skaitmens tipas, nors atrodo kad talpina raide. integer ar ushort analogas.


        }
    }
}