using System.Text;

namespace P017_StringBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, StringBuilder!");

            //StringBuilder sukurimas
            StringBuilder sb = new StringBuilder(); //be teksto
            StringBuilder sb1 = new StringBuilder("Labas pasauli"); //sukurimo metu irasomas tekstas
            StringBuilder sb2 = new StringBuilder(123456); //sukurimo metu taip pat irasomas tekstas

            //Teksto isgavimas is StringBuilder
            Console.WriteLine(sb.ToString());

            //Teksto pridejimas per StringBuilder
            sb.Append("Labas");
            sb.AppendLine("pasauli");
            sb.AppendLine("labas C#");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("-----------------------------");
            //Teksto iterpimas
            sb.Insert(14, " AAAAAA ");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("-----------------------------");
            //Teksto pasalinimas
            sb.Remove(6, 2);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("-----------------------------");
            //Teksto pakeitimas
            sb.Replace("labas", "Hellow");
            Console.WriteLine(sb.ToString());
        }

        public static string For_Concat()
        {
            string s = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                s += i;
            }
            return s;
        }
        public static string For_StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }


    }
}