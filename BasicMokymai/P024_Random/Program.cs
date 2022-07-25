namespace P024_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random!");
            //kosntruojamas naujas Random
            Random random = new Random();

            int aRandomNumber = random.Next(); // sugeneruotas betkoks ksiacius nuo 0 iki Int32.MaxValue
            int aRandomNumber1 = random.Next(4); //sugeneruota 0,1,2 arba 3
            int aRandomNumber2 = random.Next(1,4);    //bus sugeneruota 1,2 arba 3

            double dRandomNumber = random.NextDouble(); //>=0.0 iki < 1.0

            Console.WriteLine(RandomMetodasDebuginamas()); //neimanoma testuoti
            Console.WriteLine(RandomMetodas(random)); //imanoma testuoti


            //Atsitiktinis parinkimas is array ir list
            Console.WriteLine("----------------");
            Console.WriteLine("Atsitiktinis parinkimas is array ir list");




        }

        static string RandomMetodasDebuginamas()
        {


            Random rnd = new Random();
            return rnd.Next(1,10) > 5 ? "dideja": "mazeja";
        }

        static string RandomMetodas(Random rnd)
        {
            return rnd.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }
    }
}