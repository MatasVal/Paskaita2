
Console.WriteLine("Hello, Operatoriai!");

//Reliaciniai operatoriai == != > < >= <=

/*var skaicius = 10;
var nelyginisSkaicius = 5;
var lyginisSkaicius = 10;
Console.WriteLine(" == patikrina ar kintamieji yra lygus");
Console.WriteLine($"{skaicius}=={lyginisSkaicius} yra {skaicius == lyginisSkaicius}");

bool ar10yraLygu5 = skaicius == nelyginisSkaicius;
Console.WriteLine($"{skaicius}=={nelyginisSkaicius} yra {ar10yraLygu5}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("!=patikrina ar kintamieji yra nelygus");
Console.WriteLine($"{skaicius}!={lyginisSkaicius} yra {skaicius != lyginisSkaicius}");
Console.WriteLine($"{skaicius}!={nelyginisSkaicius} yra {skaicius != nelyginisSkaicius}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("> patikrina ar kaireje esanti reiksme yra didesne uz desineje esancia");
Console.WriteLine($"{skaicius}>{lyginisSkaicius} yra {skaicius > lyginisSkaicius}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("> patikrina ar kaireje esanti reiksme yra mazesneuz desineje esancia");
Console.WriteLine($"{skaicius}<{lyginisSkaicius} yra {skaicius < lyginisSkaicius}");
Console.WriteLine($"{skaicius}<{nelyginisSkaicius} yra {skaicius < nelyginisSkaicius}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("> patikrina ar kaireje esanti reiksme yra didesne arba lygi uz desineje esancia");
Console.WriteLine($"{skaicius}>={lyginisSkaicius} yra {skaicius >= lyginisSkaicius}");
Console.WriteLine($"{skaicius}>={nelyginisSkaicius} yra {skaicius >= nelyginisSkaicius}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("> patikrina ar kaireje esanti reiksme yra mazesne arba lygi uz desineje esancia");
Console.WriteLine($"{skaicius}<={lyginisSkaicius} yra {skaicius <= lyginisSkaicius}");
Console.WriteLine($"{skaicius}<={nelyginisSkaicius} yra {skaicius <= nelyginisSkaicius}");


//var a = "A";
//var b = "B";
//Console.WriteLine($"{a}>{b} yra {a > b}");

sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių
*/

/*long maxLong = 9223372036854775807;//galima ir per long.maxvalue
short maxShort = 32767;
var rezultatas3 = (double)maxLong / maxShort;

Console.WriteLine($"padalinkite didesni skaiciu is mazesnio {rezultatas3}" );

var rezultatas31 = rezultatas3 - maxLong;
Console.WriteLine($"is rezultato atimkite max long skaiciu {rezultatas31}");

Console.WriteLine($"ir pridekite maksimalu int skaiciu {rezultatas31 + int.MaxValue}");



PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
INT , SHORT , BYTE
STEBĖTI REZULTATĄ.
*/


//double didelis10 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($" int = {(int)didelis10}");
//Console.WriteLine($" short = {(short)didelis10}");
//Console.WriteLine($" byte = {(byte)didelis10}");


//Console.WriteLine( Convert.ToInt32(didelis10);


//PARAŠYTI PROGRAMĄ KURI
//PRAŠO ĮVESTI RUTULIO DIAMETRĄ,
//o IŠVEDA PLOTĄ IR TŪRĮ

/*
Console.WriteLine("irasykite rutulio diametra, apskaiciuosime plota ir turi");

var sphereDiameter = double.Parse(Console.ReadLine());
var sphereRadius = sphereDiameter / 2;
var sphereArea = 4 * 3.14 * sphereRadius * sphereRadius;
var spherevolume = (4 / 3) * 3.14 * (sphereRadius * sphereRadius * sphereRadius);
*/

/*PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (METRAIS) IR LAIKĄ(SEKUNDĖMIS),
-IŠVEDA GREITĮ km/h.
- IŠVEDA GREITĮ km/s.*/

/*Console.WriteLine("iveskite atstuma metreais");
var atstumas = double.Parse(Console.ReadLine());
var laikas = double.Parse(Console.ReadLine());

var metruKiekisKilometre = 
var sekKiekisValandoje = 

Console.WriteLine();

var greitisKMPerH = atstumas
var greitisKMPerS =
*/



/*Nuskaitykite iš klaviatūros 2 skaičius (x ir y).
Išveskite į ekraną funkciją y+2y+x+1 ir apskaičiuokite šios funkcijos rezultatą.
Išveskite į ekraną funkciją y²+x/2 apskaičiuokite šios funkcijos rezultatą.

Console.WriteLine("iveskite x");
var x = int.Parse(Console.ReadLine());
Console.WriteLine("iveskite y");

var y = int.Parse(Console.ReadLine());

Console.WriteLine($" y+2y+x+1 = {y + 2 * y + x + 1}");
Console.WriteLine($" y*y +x/2 = {y * y + x / 2}");*/


/*PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
PVZ BUVO ĮVESTA 12345
REZULTATAS 2345/2=1172,5
<HINT> naudokite replace
*/

/*
 Console.WriteLine("iveskite penkiazenkli sveikaji skaiciu:");

var skaicius = Convert.ToDouble(Console.ReadLine().Replace("1", "0"));
Console.WriteLine($"{skaicius}/2={skaicius/2}");





PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
PVZ BUVO ĮVESTA 12345
REZULTATAS 10000/2=5000
<HINT> naudokite replace
*/
/*

Console.WriteLine("iveskite penkiazenkli sveikaji skaiciu:");

var skaicius = Convert.ToDouble(Console.ReadLine()//is konsoles nuskaitau stringa
    .Replace("2", "0")
    .Replace("3", "0")
    .Replace("4", "0")
    .Replace("5", "0")
    .Replace("6", "0")
    .Replace("7", "0")
    .Replace("8", "0")
    .Replace("9", "0")
    );
Console.WriteLine($"{skaicius}/2={skaicius / 2}");

 
 


 PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
PVZ BUVO ĮVESTA 5
REZULTATAS 6 7 8 9 10
*/

/*Console.WriteLine("iveskite sveika skaiciu:");

var skaicius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" rezultatas {++skaicius}{++skaicius}{++skaicius}{++skaicius}{++skaicius}");

*/











