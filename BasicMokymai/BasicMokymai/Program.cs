namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eilutėje ");
            Console.WriteLine();
            Console.WriteLine("tekstas kitoje eilutėje");
            Console.Write("tekstas");

            Console.WriteLine("-------------");
            Console.WriteLine("išvedimas "+ "vienoje " + "eilutėje "); //konkatinacija
            Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje","eilutėje"); //kompozicija
            Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eilutėje"}"); //interpoliacija
            Console.WriteLine("-------------");

            Console.WriteLine("tekstas idedamas i \"kabutes\" ");
            Console.WriteLine($"tekstas {Environment.NewLine}\nidedamas \r\ni \r\n\"kabutes\" ");
            Console.WriteLine("tekstas \tidedamas \ti \t\"kabutes\" ");

            
            Console.WriteLine("----Press any key to continue------");
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("Įveskite savo vardą, o aš jį pakartosiu:");
            //Console.WriteLine("o štai mano pakartojimas " + Console.ReadLine());
            //Console.WriteLine("o štai mano pakartojimas {0}", + Console.ReadLine());
            //Console.WriteLine($"o štai mano pakartojimas {0}  Console.ReadLine()");

            //Console.WriteLine("Įveskite raidę");
            //var key = Console.ReadKey();
            //Console.WriteLine("ivestas simbolis {0}",  key.KeyChar);
            //Console.WriteLine("ivestas simbolis {0}", key.Key);
            //Console.WriteLine("ivestas simbolis {0}", (int)key.KeyChar);

            //Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);

            Console.WriteLine("Įveskite savo vardą, o as atspesiu pirma raide:");
            Console.WriteLine("o štai mano spejimas \"" + Console.ReadLine()[0] + "\"");

            Console.ReadKey();
        }
    }
}