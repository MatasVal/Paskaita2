
Console.WriteLine("Hello, String!");
/*


//var a = Console.WriteLine("kazkas");           //negrazina reiksmes, naudoti be priskyrimo

//var b = Console.ReadLine();                 //toks metodas grazina reiksme


//string c = Console.ReadKey();                       // irgi grazina reiksme, bet ne tokio tipo kokio norim

//ConsoleKeyInfo c = Console.ReadKey();


Console.WriteLine("String manipuliacijos");


Console.WriteLine("**********   string constructor");
char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //turime array
string greetings = new string (letters); //string constructor

string vardas = "Petras";
DateTime siandien = DateTime.Today;
Console.WriteLine(greetings);

Console.WriteLine(greetings[1]);
Console.WriteLine(letters[1]);
Console.WriteLine(vardas[2]);


//----------------------------
Console.WriteLine("**********   string concatination");

var pilnasVardas = vardas + " Pavardenis";
Console.WriteLine(pilnasVardas);


//----------------------------
Console.WriteLine("**********   string composition");
var vardasIrData = string.Format("{0} data={1}", vardas, siandien);
Console.WriteLine(vardasIrData);

//----------------------------
Console.WriteLine("**********   string interpolation");
var vardasIrData1 = $"{vardas} data={siandien}";
Console.WriteLine(vardasIrData1);

//----------------------------
Console.WriteLine("//----------------------------");
string nullas = null;
string baltaEdrve = "              ";
string tuscia ="";
string tuscia1 = string.Empty;

Console.WriteLine("ar \"\" yra tapatu string.Empty? {0}", tuscia == tuscia1);
Console.WriteLine("ar \"\" yra tapatu balta.Edrve? {0}", tuscia == baltaEdrve);
bool arTuscia = string.IsNullOrEmpty(vardas);
Console.WriteLine($"arTuscia ={arTuscia}");
bool arNullas = string.IsNullOrEmpty(nullas);
Console.WriteLine($"arNullas={arNullas}");


bool arBaltaErdveYraTuscia = string.IsNullOrEmpty(baltaEdrve);
Console.WriteLine($"arBaltaErdveYraTuscia={arBaltaErdveYraTuscia}");

bool arBaltaErdve =string.IsNullOrWhiteSpace(baltaEdrve);
Console.WriteLine($"arBaltaErdve={arBaltaErdve}");


//----------------------------
Console.WriteLine("----------------------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"eilute {Environment.NewLine} nauja";
string aa5 = $"kelias diskineje sistemoje {Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}windows";  //vietoj \\, jeigu butu kita operacine sistema galimai naudojama
string aa6 = $"{{  }}";
string aa7 = @"galime
rasyti 
teksta 
per kelias \ { @ "" 
eilutes";
//cia escapint reikia tik kabutes, rasyti du kartus kabutes

Console.WriteLine("----------------------------");


double skaicius = 6.556456465465456;
string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.00");
Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio);

*/


