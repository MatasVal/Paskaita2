using System.Diagnostics;
using System.Globalization; //sita reikejo prideti papildomai kad iseitu naudotu Culture

namespace P014_Debug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            //Pinigas();

            Console.WriteLine(DecimalHour(Console.ReadLine()));
        }
        


        public static void Pinigas()
        {
            Console.WriteLine("Iveskite pinigu suma");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            Debug.WriteLine("Labas");
            //var rezultatas = Convert.ToInt32(suma) * kursas; //reikalinga korekcija jei ivestas didelis skaicius
            //var rezultatas = Convert.ToInt64(suma) * kursas; //reikalinga korekcija del trupmeninio skaiciaus pvz 20.4
            //var rezultatas = Convert.ToDouble(suma) * kursas; ////reikalinga korekcija del trupmeninio skaiciaus su tasku pvz 20.4
            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var groupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            suma = suma.Replace(decimalSeparator, groupSeparator);


            var rezultatas = Convert.ToDouble(suma) * kursas;
            Console.WriteLine("Jus turite rankoje {0} pinigus", rezultatas);
            Debug.WriteLine("Jus turite rankoje {0} pinigus", rezultatas); //ctrl taskas, system diagnostics reikia
            Console.ReadKey();

        }




        public static string DecimalHour(string input)
        {
            /*
             * var a = input.Split(".");
            if (a.Length < 2)
            {                
                return "Invalid time";
            }
            if (!int.TryParse(a[0], out int hour) || hour < 0)
            {                
                return "Invalid hours";
            }
            if (!int.TryParse(a[1], out int minute) || minute < 0 || minute > 60)
            {                
                return "Invalid minutes";
            }
            if (a.Length > 2 && (!int.TryParse(a[1], out int sec) || sec < 0 || sec > 60))
            {                
                return "Invalid seconds";
            }
            */



            var isInputValid = IsDecimalHourInputValid(input, out string? msg);
            if (!isInputValid)
                return msg;



            var ivedimoDalys = input.Split(".");
            var dec = Convert.ToDecimal(ivedimoDalys[0]) +   //valandos
                      (Convert.ToDecimal(ivedimoDalys[1]) / 60) + // pridedame minutes
                      (ivedimoDalys.Length > 2 ? (Convert.ToDecimal(ivedimoDalys[2]) /3600) : 0);


            
            return $"Decimal hour; {dec:0.0000}";




            
        }
        private static bool IsDecimalHourInputValid(string input, out string msg)
        {
            msg = null;
            var a = input.Split(".");
            if (a.Length < 2)
            {
                msg = "Invalid time";
            }
            if (!int.TryParse(a[0], out int hour) || hour < 0)
            {
                msg = "Invalid hours";
            }
            if (!int.TryParse(a[1], out int minute) || minute < 0 || minute > 60)
            {
                msg = "Invalid minutes";
            }
            if (a.Length > 2 && (!int.TryParse(a[1], out int sec) || sec < 0 || sec > 60))
            {
                msg = "Invalid seconds";
            }
            return false;
        }


        private static bool IsDecimalHourInputTimeInValid(string[] a) => a.Length < 2;

        private static bool IsDecimalHourInputHourInValid(string[] a) => !int.TryParse(a[0], out int hour) || hour < 0;

        private static bool IsDecimalHourInputMinuteInValid(string[] a) => !int.TryParse(a[1], out int minute) || minute < 0 || minute > 60;

        private static bool IsDecimalHourInputSecondsInValid(string[] a) => a.Length > 2 && (!int.TryParse(a[1], out int sec) || sec < 0 || sec > 60)
    }
}