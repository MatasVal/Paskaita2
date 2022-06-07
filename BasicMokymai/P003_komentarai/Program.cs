namespace P003_komentarai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Komentarai *****");
            Console.WriteLine("Kokie buna komentarai?");
            // čia paprastas komentaras
            /*
            čia 
            multi-line
            komentaras
                   
              */
            Console.WriteLine(); //komentaras
            var kintamasis = /* kazkoks komentaras */ "galima taip";

            Console.WriteLine("Kodel reikia rasyti komentarus?");
            Console.WriteLine("Kaip rašyti gerus komentarus?");
            /*
             *  1 . reikia rašyti komentarus kodo gabalui kuris yra funkciškai išbaigtas
             *  2. reikia rašyti komentarus kurie prideda kodui prasmės, o ne tiesiog pasako ką kodas daro
             */

            //Blogas komentaro pvz:
            //Console.WriteLine naudojamas į ekraną išvesti Hello World!'
            Console.WriteLine("Hello World!");

            /*Juk ir taip aišku ką daro kodas.. išmokime skaityti kodą
             */

            //Geras komentaro pvz:
            //Išvesti Hello World! tai mano pirmoji veikianti programa.
            Console.WriteLine("Hello World!");
            /*Toks komentaras man atsako į klausimą kodėl yra šita kodo eilutė, o ne ką ji daro */



        }
    }
}