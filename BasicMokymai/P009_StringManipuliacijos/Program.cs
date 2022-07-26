
Console.WriteLine("Hello, String!");
Console.WriteLine("Hello, sring!");

//Console.WriteLine("kazkas");
string b = Console.ReadLine();
//ConsoleKeyInfo c = Console.ReadKey();


Console.WriteLine("String manipuliacijos");

Console.WriteLine("****** string constructor");
char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //array
string greetings = new string(letters); //string constructor
string vardas = "Petras";
DateTime siandien = DateTime.Today;

Console.WriteLine(greetings);

Console.WriteLine(letters[1]);
Console.WriteLine(greetings[1]);
Console.WriteLine(vardas[2]);

//---------------------------
Console.WriteLine("****** string concationation");
var pilnasVardas = vardas + " Pavardenis";
Console.WriteLine(pilnasVardas);

//---------------------------
Console.WriteLine("****** string composition");
var vardasIrData = string.Format("{0} data={1}", vardas, siandien);
Console.WriteLine(vardasIrData);

//---------------------------
Console.WriteLine("****** string interpolation");
var vardasIrData1 = $"{vardas} data={siandien}";
Console.WriteLine(vardasIrData1);

//-----------------------
Console.WriteLine("------------------------------------");
string nullas = null;
string baltaErdve = "                           ";
string tuscia = "";
string tuscia1 = string.Empty;
Console.WriteLine("ar \"\" yra tapatu string.Empty? {0}", tuscia == tuscia1);
Console.WriteLine("ar \"\" yra tapatu baltaErdve? {0}", tuscia == baltaErdve);
bool arTuscia = string.IsNullOrEmpty(tuscia);
Console.WriteLine($"arTuscia={arTuscia}");

bool arNullas = string.IsNullOrEmpty(nullas);
Console.WriteLine($"arNullas={arNullas}");

bool arBaltaErdveYraTuscia = string.IsNullOrEmpty(baltaErdve);
Console.WriteLine($"arBaltaErdveYraTuscia={arBaltaErdveYraTuscia}");

bool arBaltaErdve = string.IsNullOrWhiteSpace(baltaErdve);
Console.WriteLine($"arBaltaErdve={arBaltaErdve}");

//-----------------------
Console.WriteLine("------------------------------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"elute  {Environment.NewLine} nauja";
string aa5 = $"kelias diskinėje sistemoje {Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}windows";
string aa6 = $"{{  }}";
string aa7 = @" galime
rasyti teksta
per \ { @ "" 
kelias eilutes";

//-----------------------
Console.WriteLine("------------------------------------");
double skaicius = 22222.656646564665646;
string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.00");
Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio);




//-----------------------
Console.WriteLine("------------------------------------");

Console.WriteLine("******** TryParse ******** ");

string v1 = null;
string v2 = "160519";
string v3 = "9432.0";
string v4 = "16,667";
string v5 = "   -322     ";
string v6 = " +4302";
string v7 = "(100)";
string v8 = "01FA";
string v9 = "0x01FA";
string v10 = "001";

bool success1 = int.TryParse(v1, out int number1);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v1, success1);
bool success2 = int.TryParse(v2, out _);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v2, success2);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v3, double.TryParse(v3, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v4, double.TryParse(v4, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v5, int.TryParse(v5, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v6, int.TryParse(v6, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v7, int.TryParse(v7, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v8, int.TryParse(v8, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v9, int.TryParse(v9, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v10, int.TryParse(v10, out _));

//--------------------------------------
//STRING METODAI
Console.WriteLine("-----------------------------------------");
Console.WriteLine("******** Clone() string dalies klonavimas ******** ");
{
    var vardas_2 = vardas.Clone();
    var vardas_3 = vardas;
    Console.WriteLine($"klonuotas vardas {vardas_2} ");
}
//-----------------------
{
    Console.WriteLine("******** CompareTo() string palyginimas ********");
    string strFirst = "Goodbye";
    string strSecond = "Hello";
    int cmpVal = strFirst.CompareTo(strSecond);
    //grazins -1 jei strFirst < strSecond
    //grazins 0 jei strFirst = strSecond
    //grazins 1 jei strFirst > strSecond
}
//-----------------------
var netvarkingasTekstas = " Kazkoks NEtvarkingAS Tekstas Su tarPais ir 155 0051 skaičiais ";

{
    Console.WriteLine("******** Contains() paieška string viduje ******** ");
    string etr = " etr";
    Console.WriteLine($"ar vardas {vardas} viduje turi {etr}? {vardas.Contains(etr)}");
    Console.WriteLine($"ar vardas {netvarkingasTekstas} viduje turi 'AS Te'? {netvarkingasTekstas.Contains("AS Te")}");
}
//-----------------------
{
    Console.WriteLine("******** EndsWith() paieška string gale ******** ");
    Console.WriteLine($"ar vardas {vardas} pradideda 'nas'? {vardas.EndsWith("nas")}");
    Console.WriteLine($"ar vardas {vardas} pradideda 'ras'? {vardas.EndsWith("ras")}");
}
//-----------------------
{
    Console.WriteLine("******** Equals() string palyginimas ********");
    string vardasIsMazosios = "petras";
    bool arVardaiLygus = vardas == vardasIsMazosios;
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios}? {arVardaiLygus}");
    bool arVardaiLygus1 = vardas.Equals(vardasIsMazosios, StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios} su IgnoreCase: {arVardaiLygus1}");
}
//-----------------------
{
    Console.WriteLine("******** IndexOf() grąžina indeksą pirmo sutikto atitikmens ******** ");
    Console.WriteLine(netvarkingasTekstas);
    Console.WriteLine("e raidės indeksas " + netvarkingasTekstas.IndexOf("e")); //grazina 23
    Console.WriteLine("a raidės indeksas " + netvarkingasTekstas.IndexOf("a")); //grazina 2
    Console.WriteLine("x raidės indeksas " + netvarkingasTekstas.IndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** ToLower() visas raides padaro mažosiom ******** ");
    var tekstasSuTarpaisMazosiomis = netvarkingasTekstas.ToLower();
    Console.WriteLine($"tekstasSuTarpais mažosiomis ({tekstasSuTarpaisMazosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** ToUpper() visas raides padaro didziosiom ******** ");
    var tekstasSuTarpaisDidziosiomis = netvarkingasTekstas.ToUpper();
    Console.WriteLine($"tekstasSuTarpais didžiosiomis ({tekstasSuTarpaisDidziosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** Insert() įterpia teksta nurodytoje vietoje ******** ");
    Console.WriteLine(vardas.Insert(2, "_Hello_"));
}
//-----------------------
{
    Console.WriteLine("******** LastIndexOf() grąžina indeksą paskutinio sutikto atitikmens ******** ");
    Console.WriteLine("e raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("e")); //grazina 23
    Console.WriteLine("a raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("a")); //grazina 59
    Console.WriteLine("x raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** Length string ilgis (simboliu kiekis)  ********");
    Console.WriteLine(vardas.Length);
}
//-----------------------
{
    Console.WriteLine("******** Remove() pašalna simbolius  ********");
    Console.WriteLine(vardas.Remove(2)); //iki galo

    Console.WriteLine(vardas.Remove(0, 1)); //kiek nurodyta
    Console.WriteLine(vardas.Remove(vardas.Length - 1, 1));
}
//-----------------------
{
    Console.WriteLine("******** Replace() raidžių keitimas string viduje ******** ");
    var pakeistasaTekstas = netvarkingasTekstas.Replace("a", "_=_");
    Console.WriteLine($"pakeistasa tekstas {pakeistasaTekstas} ");
}
//-----------------------
{
    Console.WriteLine("******** Split() teksto skaidymas ******** ");
    string[] split = vardas.Split('e'); //Split the string based on specified value
    Console.WriteLine(split[0]);
    Console.WriteLine(split[1]);
}
//-----------------------
Console.WriteLine("******** StartsWith() paieška string pradžioje ******** ");
{
    Console.WriteLine($"ar vardas {vardas} pradideda 'Jon'? {vardas.StartsWith("Jon")}");
}
//-----------------------
{
    Console.WriteLine("******** Substring() dalies string nuskaitymas ******** ");
    var dalisTeksto = netvarkingasTekstas.Substring(2);
    Console.WriteLine($"dalis teksto {dalisTeksto} ");

    var dalisTeksto1 = netvarkingasTekstas.Substring(2, 10);
    Console.WriteLine($"dalis teksto {dalisTeksto1} ");
}
//-----------------------
{
    Console.WriteLine("******** Trim() tekstas su tarpais trim ******** ");

    Console.WriteLine($"tekstasSuTarpais ({netvarkingasTekstas}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ir priekyje ({netvarkingasTekstas.Trim()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais priekyje  ({netvarkingasTekstas.TrimStart()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ({netvarkingasTekstas.TrimEnd()}).");

}


/* 
           Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
           Vartotojas įveda:
            - vardą ir pavardę 
            - asmens kodą (11simb.)
            - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
          Programa į ekraną išveda ataskatą:
           - šiandienos datą
           - Vardas, pavardė
           - Lytis
              <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį 
              (1 – XIX a. gimęs vyras, 
               2 – XIX a. gimusi moteris, 
               3 – XX a. gimęs vyras,
               4 – XX a. gimusi moteris, 
               5 – XXI a. gimęs vyras,
               6 – XXI a. gimusi moteris
               tolesni šeši: 
                    metai (du skaitmenys), 
                    mėnuo (du skaitmenys), 
                    diena (du skaitmenys))     
           - Asmens kodas 
              <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                 Paskaičiuojamas Kontrolinis skaičius 
                 a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                 b) jei neteisingas išvedamas tekstas "kodas neteisingas", 
                    o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų" 
                    <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
           - Amžius
           - Amžiaus patikimumas - pagal tokias sąlygas:
           -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas"
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta gimimo data sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas" 
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu. 
              a) jei viskas sutampa išvesti "amžius tikras" 
              b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas" 
              c) jei nesutampa išvesti "amžius pameluotas"
           - jei neįvesta nei amžius nei gimimo data išvesti
              a) "patikimumui trūksta duomenų"


Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

           */



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


