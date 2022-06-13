
Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=");
int skaicius;
int kitasSkaicius = 20;
int nelyginisSkaicius = 5;

skaicius = 10;
kitasSkaicius = skaicius;
Console.WriteLine($"skaicius= {skaicius}, kitasSkaicius = {kitasSkaicius}");//atimantis priskyrimas/operatorius

kitasSkaicius += nelyginisSkaicius;//pridedantis priskyrimas //kitasSkaicius = kitasSkaicius + nelyginisSkaicius // tai analogas
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius -= nelyginisSkaicius;//atimantis priskyrimas
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius *= nelyginisSkaicius;//dauginantis priskyrimas
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius /= nelyginisSkaicius;//dalybos priskyrimas
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius = 21;

kitasSkaicius /= nelyginisSkaicius;//keiciam reiksme ir naudojam dalybos operatoriu
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

double doubleSkaicius = 21;

doubleSkaicius /= (double)nelyginisSkaicius;
Console.WriteLine($"doubleSkaicius = {doubleSkaicius}");

Console.WriteLine();
Console.WriteLine("Hello, matematiniai operatoriai + - * / % ++ --");


//sudetis
int suma = skaicius + kitasSkaicius;




Console.WriteLine("   suma=skaicius + kitasSkaicius = {0}", suma);
int atimtis = skaicius - kitasSkaicius;
Console.WriteLine(" atimtis = skaicius - kitasSkaicius = {0}", atimtis);
int daugyba = skaicius * kitasSkaicius;
Console.WriteLine("daudyba =skaicius * kitasSkaicius = {0}", daugyba);
double dalyba = (double)skaicius / kitasSkaicius;
Console.WriteLine(" dalyba = skaicius / kitasSkaicius = {0}", dalyba);

int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

//dalyba su liekana

var dalybaSuLiekana = nelyginisSkaicius % 2;
Console.WriteLine("dalybaSuLiekana = nelyginisSkaicius % 2 = {0}", dalybaSuLiekana);


skaicius++;
Console.WriteLine($"skaicius={skaicius}");

skaicius--;
Console.WriteLine($"skaicius={skaicius}");