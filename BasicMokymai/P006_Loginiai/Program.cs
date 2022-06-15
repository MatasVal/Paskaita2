/*
Console.WriteLine("Hello, Loginiai Operatoriai!");
Console.WriteLine("&& (AND), || (OR), ! (NOT), ^ (XOR)");

Console.WriteLine("Neigimas !");

bool tiesa = true;
bool melas = !tiesa;

Console.WriteLine($"tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");

Console.WriteLine("AND &&");
Console.WriteLine($"tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($"tiesa AND melas {tiesa && melas}");
Console.WriteLine($"melas AND tiesa {melas && tiesa}");
Console.WriteLine($"melas AND melas {melas && melas}");


Console.WriteLine("OR ||");
Console.WriteLine($"tiesa OR tiesa {tiesa || tiesa}");
Console.WriteLine($"tiesa OR melas {tiesa || melas}");
Console.WriteLine($"melas OR tiesa {melas || tiesa}");
Console.WriteLine($"melas OR melas {melas || melas}");

Console.WriteLine("XOR ^");
Console.WriteLine($"tiesa XOR tiesa {tiesa ^ tiesa}");
Console.WriteLine($"tiesa XOR melas {tiesa ^ melas}");
Console.WriteLine($"melas XOR tiesa {melas ^ tiesa}");
Console.WriteLine($"melas XOR melas {melas ^ melas}");

Console.WriteLine("NAND ! &&"); //priesingybe AND
Console.WriteLine($"tiesa NAND tiesa {!(tiesa && tiesa)}");
Console.WriteLine($"tiesa NAND melas {!(tiesa && melas)}");
Console.WriteLine($"melas NAND tiesa {!(melas && tiesa)}");
Console.WriteLine($"melas NAND melas {!(melas && melas)}"); //arba {!melas && !melas}

Console.WriteLine("NOR ! OR"); //priesingas OR
Console.WriteLine($"tiesa NOR tiesa {!(tiesa || tiesa)}");
Console.WriteLine($"tiesa NOR melas {!(tiesa || melas)}");
Console.WriteLine($"melas NOR tiesa {!(melas || tiesa)}");
Console.WriteLine($"melas NOR melas {!(melas || melas)}");

Console.WriteLine("NXOR ! ^"); //priesingas XOR
Console.WriteLine($"tiesa NXOR tiesa {!(tiesa ^ tiesa)}");
Console.WriteLine($"tiesa NXOR melas {!(tiesa ^ melas)}");
Console.WriteLine($"melas NXOR tiesa {!(melas ^ tiesa)}");
Console.WriteLine($"melas NXOR melas {!(melas ^ melas)}");

Console.WriteLine($"melas OR tiesa OR melas AND tiesa {melas || tiesa || (melas && tiesa)}");//operaciju vykdymo tvarka skliaustais galima pakeisti

int a = 5;
int b = 5;
int c = 6;
bool s = a >= b && a > c || tiesa;
Console.WriteLine(s);


PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGŪS,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/

//Console.WriteLine("iveskite du skaicius");
//var a =Convert.ToInt32(Console.ReadLine());
//var b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"ar lygus {a == b}");









/*PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGiniai,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/

/*Console.WriteLine("iveskite du skaicius");
var a = Convert.ToInt32(Console.ReadLine());
var b = Convert.ToInt32(Console.ReadLine());
bool ra = a % 2 == 0;
bool rb = b % 2 == 0;
bool r = ra && rb;

bool r1 = a % 2 == 0 && b % 2 == 0;

Console.WriteLine(r1); 

 







 
 Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
kanalas A __---___---___---___---___
kanalas B ____---___---___---___---_
Apatinis brūkšnys (_) reiškia false, o paprastas (-) true.
Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
e) (A OR B) NAND A



atsakymas:
a) ____-_____-_____-_____-___
b) __-----_-----_-----_-----_
c) __--_--_--_--_--_--_--_--_

 */

var kanalasA = "__---___---___---___---___";
var kanalasB = "____---___---___---___---_";

Console.WriteLine("A" kanalasA.ToString().Replace("_", "false").Replace("-", "true"));



bool low = false;
bool high = true;

//Console.WriteLine(_);

//Console.WriteLine("A AND B");
//Console.WriteLine($"A AND B {kanalasA && kanalasB}");

//Console.WriteLine($"{false && false}");



