
//*Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
Console.WriteLine("prasome ivesti viena skaiciu:");
var celsius = Convert.ToDouble(Console.ReadLine());

//- Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.

var farenheitas = (celsius * 9 / 5) + 32;
var kelvinas = celsius + 273.15;

Console.WriteLine($"Farenheitas ={(celsius*9/5) +32}");

//- Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
Console.WriteLine($"Kelvinas ={celsius+273.15}");

//- Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
Console.WriteLine($"konvertuojamas farenheitas atgal i celsiju = {(farenheitas -32) /1.8} ");

bool vertimas0 = (farenheitas - 32) / 1.8 == celsius;
Console.WriteLine($"ar sutampa farenheitas su celsijumi - {vertimas0} ");

//-Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
Console.WriteLine($"konvertuojamas kelvinas atgal i celsiju = {kelvinas - 273.15} ");

bool vertimas1 = kelvinas - 273.15 == celsius;

Console.WriteLine($"ar sutampa kelvinas su celsijumi - {vertimas1} ");

//-Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)



bool vertimas2 = (farenheitas - 32) / 1.8 + 273.15 == celsius;

Console.WriteLine($"ar sutampa farenheito vertimas i kelvina su ankstesniais skaiciavimais - {vertimas2} ");

//-Nupieškite termometrą pagal Celsijų 
//a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
//(tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)

Console.WriteLine($" {celsius} +40 \n
+ 35
+ 30
+ 25
+ 20
+ 15
+ 10
+ 5
+ 0
- 5
- 10
- 15
- 20
- 25
- 30
- 35
- 40;


// b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
//<HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir.Replace().
// if naudoti negalima, ternary operator (?) naudoti negalima.







/*rezultatas gali atrodyti taip:
                            |--------------------|
                            |   ^F _    ^C   |
                            |  100  - | | -  40  |
                            |   95  - | | -  35  |
                            |   90  - | | -  30  |
                            |   80  - | | -  25  |
                            |   70  - | | -  20  |
                            |   60  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   40  - |#| -   5  |
                            |   30  - |#| -   0  |
                            |   20  - |#| -  -5  |
                            |   10  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |    0  - |#| - -20  |
                            |  -10  - |#| - -25  |
                            |  -20  - |#| - -30  |
                            |  -30  - |#| - -35  |
                            |  -40  - |#| - -40  |
                            |        '***`       |
                            |       (*****)      |
                            |        `---'       |
                            |____________________|

*/

//lygiavimas



//var a= "123";
//Console.WriteLine($" |---{a,4}---|"   );
//Console.WriteLine($" |----------|");