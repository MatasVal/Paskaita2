using System.Text;

namespace P017_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, String Builder!");


            //StringBuilder sukurimas
            StringBuilder sb = new StringBuilder(); // be teksto
            StringBuilder sb1 = new StringBuilder("Labas pasauli"); // sukurimo metu irasomas tekstas
            StringBuilder sb2 = new StringBuilder(123456); // sukurimo metu taip pat irasomas tekstas

            //Teksto isgavimas is StringBuilder
            Console.WriteLine(sb.ToString());

            //Teksto pridejimas per StringBuilder

            sb.Append("Labas");
            sb.Append("pasauli");
            sb.AppendLine();
            sb.AppendLine("Labas c#");

            Console.WriteLine(sb.ToString());


            //Teksto iterpimas

            sb.Insert(5, " AAAAAA ");
            Console.WriteLine(sb.ToString());


            //Teskto pasalinimas

            sb.Remove(6, 2);
            Console.WriteLine(sb.ToString());

            //Teksto pakeitimas
            sb.Replace("Labas", "Hello");
            Console.WriteLine(sb.ToString());

        }
    }
}