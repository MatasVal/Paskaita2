/*
 Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
             Vartotojas įveda:
              -vardą ir pavardę
              - asmens kodą (11simb.)
              -amžių(sveiką skaičių metais) ir / arba gimimo datą(galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
            Programa į ekraną išveda ataskatą:
             -šiandienos datą
             - Vardas, pavardė
             - Lytis
                < HINT > asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį
                (1 – XIX a. gimęs vyras,
                 2 – XIX a. gimusi moteris,
                 3 – XX a. gimęs vyras,
                 4 – XX a. gimusi moteris,
                 5 – XXI a. gimęs vyras,
                 6 – XXI a. gimusi moteris
                 tolesni šeši:
                      metai(du skaitmenys),
                      mėnuo(du skaitmenys),
                      diena(du skaitmenys))    
             -Asmens kodas
                < NEPRIVALOMAS PASUNKINIMAS > asmens kodas validuojamas pagal tokias salygas
                   Paskaičiuojamas Kontrolinis skaičius
                   a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                   b) jei neteisingas išvedamas tekstas "kodas neteisingas",
                      o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų"
                      <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
             -Amžius
             - Amžiaus patikimumas - pagal tokias sąlygas:
             -jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu.
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


Console.WriteLine("Prasome ivesti savo varda ir pavarde:");
string vardasPavarde = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Prasome ivesti savo asmens koda (11 simb.):");
var asmensKodoIvestis = Console.ReadLine();
long asmensKodas;
bool arAsmensKodasYraSkaicius = long.TryParse(asmensKodoIvestis, out asmensKodas); //patikrinu ar asmens kodas yra skaicius

if (arAsmensKodasYraSkaicius) 
{
        if (asmensKodas < 10000000000)
        {
        Console.WriteLine("Ivestas per mazas skaitmuo");
        Environment.Exit(0);
        }
        else if (asmensKodas > 69999999999)
        {
        Console.WriteLine("Ivestas per didelis skaitmuo");   //jeigu asm. kodas yra skaicius tikrinu ar ji sudaro tinkamas kiekis skaitmenu
        Environment.Exit(0);
        }
}
else
{
    Console.WriteLine("Asmens koda turi sudaryti vien skaitmenys"); //jeigu asm kodas yra sudarytas ne is skaitmenu ar ne tik is skaitmenu, darbas nutraukiamas
    Environment.Exit(0);
}
Console.WriteLine();

Console.WriteLine("Prasome ivesti savo amziu:");

var amzius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Prasome ivesti savo gimimo data:");

var gimimoDataIvesta = DateTime.Parse(Console.ReadLine());
 
var gimimoDataSuformatuota = gimimoDataIvesta.ToString("yyyy-MM-dd"); //pasidarau kintamaji kuris yra suformatuota gimimo data

Console.WriteLine();

var siandienosDataSuformatuota = DateTime.Now.ToString("yyyy-MM-dd");

string lytis = (asmensKodas >= 10000000000 && asmensKodas <= 19999999999 || asmensKodas >= 30000000000 && asmensKodas <= 39999999999 || asmensKodas >= 50000000000 && asmensKodas <= 59999999999) ? "Vyras" : "Moteris";

var gimimoMetaiIsskaiciuoti =
if (amzius) 

bool arAmziusYraIvestas = string.IsNullOrEmpty(amzius);


Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {siandienosDataSuformatuota,10}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓     Vardas, pavardė ▓ {vardasPavarde,-30}      ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓               Lytis ▓ {lytis,-7}                               ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓        Asmens kodas ▓ {asmensKodas,11}                         ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓              Amžius ▓ {amzius,2}                                  ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓         Gimimo data ▓ {gimimoDataSuformatuota,10}                          ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");