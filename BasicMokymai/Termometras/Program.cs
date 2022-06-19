
//*Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 


Console.WriteLine("Prasome ivesti temperatūrą pagal Celsijų:");
var celsius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//- Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.


var farenheitas = (celsius * 9 / 5) + 32;
var kelvinas = celsius + 273.15;
Console.WriteLine($"Temperatūra pagal Farenheitą: {(celsius*9/5) +32}");
Console.WriteLine();


//- Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.


Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine($"Temperatūra pagal Kelviną: {celsius+273.15}");
Console.WriteLine();


//- Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)


Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine($"Konvertuojamas Farenheitas atgal i Celsiju = {(farenheitas -32) /1.8} ");
bool vertimas0 = (farenheitas - 32) / 1.8 == celsius;
Console.WriteLine($"Ar sutampa Farenheitas su Celsijumi: {vertimas0} ");
Console.WriteLine();

//-Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)


Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine($"Konvertuojamas Kelvinas atgal i Celsiju = {kelvinas - 273.15} ");
bool vertimas1 = kelvinas - 273.15 == celsius;
Console.WriteLine($"Ar sutampa Kelvinas su Celsijumi: {vertimas1} ");
Console.WriteLine();


//-Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)

bool vertimas2 = (farenheitas - 32) / 1.8 + 273.15 == celsius; // ankstesni skaiciavimai sutampa su "celsius" todel jam ir prilyginama
Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine($"Ar sutampa Farenheito vertimas i Kelvina su ankstesniais skaiciavimais: {vertimas2} ");
Console.WriteLine();


//-Nupieškite termometrą pagal Celsijų 
//a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
//(tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)


Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine("Isvesta skale kuri kinta priklausomai nuo ivestos temperaturos:");
Console.WriteLine();
Console.WriteLine(celsius + 40);
Console.WriteLine(celsius + 35);
Console.WriteLine(celsius + 30);
Console.WriteLine(celsius + 25);
Console.WriteLine(celsius + 20);
Console.WriteLine(celsius + 15);
Console.WriteLine(celsius + 10);
Console.WriteLine(celsius + 5);
Console.WriteLine(celsius + 0);
Console.WriteLine(celsius - 5);
Console.WriteLine(celsius - 10);
Console.WriteLine(celsius - 15);
Console.WriteLine(celsius - 20);
Console.WriteLine(celsius - 25);
Console.WriteLine(celsius - 30);
Console.WriteLine(celsius - 35);
Console.WriteLine(celsius - 40);


// b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
//<HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir.Replace().
// if naudoti negalima, ternary operator (?) naudoti negalima.


Console.WriteLine();
Console.WriteLine("----Testi----");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine("Termometras:");
Console.WriteLine();
Console.WriteLine($"|-------------------|");
Console.WriteLine($"|   ^F          ^C  |");
Console.WriteLine($"| {farenheitas +40,4} - | | - {celsius + 40,3}  |");
Console.WriteLine($"| {farenheitas + 35,4} - | | - {celsius + 35,3}  |");
Console.WriteLine($"| {farenheitas + 30,4} - | | - {celsius + 30,3}  |");
Console.WriteLine($"| {farenheitas + 25,4} - | | - {celsius + 25,3}  |");
Console.WriteLine($"| {farenheitas + 20,4} - | | - {celsius + 20,3}  |");
Console.WriteLine($"| {farenheitas + 15,4} - | | - {celsius + 15,3}  |");
Console.WriteLine($"| {farenheitas + 10,4} - | | - {celsius + 10,3}  |");
Console.WriteLine($"| {farenheitas + 5,4} - | | - {celsius + 5,3}  |");
Console.WriteLine($"| {farenheitas,4} - |#| - {celsius,3}  |");
Console.WriteLine($"| {farenheitas - 5,4} - |#| - {celsius - 5,3}  |");
Console.WriteLine($"| {farenheitas - 10,4} - |#| - {celsius - 10,3}  |");
Console.WriteLine($"| {farenheitas - 15,4} - |#| - {celsius - 15,3}  |");
Console.WriteLine($"| {farenheitas - 20,4} - |#| - {celsius - 20,3}  |");
Console.WriteLine($"| {farenheitas - 25,4} - |#| - {celsius - 25,3}  |");
Console.WriteLine($"| {farenheitas - 30,4} - |#| - {celsius - 30,3}  |");
Console.WriteLine($"| {farenheitas - 35,4} - |#| - {celsius - 35,3}  |");
Console.WriteLine($"| {farenheitas - 40,4} - |#| - {celsius - 40,3}  |"); // ",3" naudojama nustatyti kiek vietos rezervuojama reiksmei, kad ivedus skirtingas tepmeraturos reiksmes termometro vaizdas neissikraipytu
Console.WriteLine($"|       /***\\       |");
Console.WriteLine($"|       |***|       |");
Console.WriteLine($"|       \\___/       |");
Console.WriteLine($"|___________________|");