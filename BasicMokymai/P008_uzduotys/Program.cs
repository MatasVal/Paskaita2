/*Console.WriteLine("Hello, switch!");
            Console.WriteLine("Iveskite meniu punkta");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Vartotojas pasirinko 1");
                    Console.WriteLine("kazkokia info");
                    break;
                case 2:
                    Console.WriteLine("Vartotojas pasirinko 2");
                    break ;
                    case 3:
                    Console.WriteLine("Vartotojas pasirinko 3");
                    break;
                case 4:
                    Console.WriteLine("Vartotojas pasirinko 4");
                    break;
                default: //galima aprasyti default logika, ji bus vykdoma jei nei vienas case neatitiko salygos
                    Console.WriteLine("Klaida");
                    break;
            }
            Console.WriteLine("---------------------");


            var isvedamasRezultatas = menuChoice switch
            {
                1 => "Vartotojas pasirinko 1",
                2 => "Vartotojas pasirinko 2",
                3 => "Vartotojas pasirinko 3",
                _ => "Vartotojas nieko nepasirinko"
            };
            Console.WriteLine(isvedamasRezultatas);

            switch (menuChoice)
            {
                case 1:
                case 2:
                    Console.WriteLine("Vartotojas pasirinko 1 arba 2");
                    break;
            
            }

Console.WriteLine("iveskite egzamino pazymi:");
var pazymys = Convert.ToInt32(Console.ReadLine());


if (pazymys >= 0 && pazymys <= 4)
{
    Console.WriteLine("nepatenkinamai");
}
else if (pazymys == 5)
{
    Console.WriteLine("silpnai");
}
else if (pazymys == 6)
{
    Console.WriteLine("patenkinamai");
}
else if (pazymys == 7)
{
    Console.WriteLine("vidutiniskai");
}
else if (pazymys == 8)
{
    Console.WriteLine("gerai");
}
else if (pazymys == 9)
{
    Console.WriteLine("labai gerai");
}
else if (pazymys == 10)
{
    Console.WriteLine("puikiai");
}

Console.WriteLine("------------------------");


switch (pazymys)
{
    case 0:
        Console.WriteLine("nepatenkinamai");
        break;
    case 1:
        Console.WriteLine("nepatenkinamai");
        break;
    case 2:
        Console.WriteLine("nepatenkinamai");
        break;
    case 3:
        Console.WriteLine("nepatenkinamai");
        break;
    case 4:
        Console.WriteLine("nepatenkinamai");
        break;
    case 5:
        Console.WriteLine("silpnai");
        break;
    case 6:
        Console.WriteLine("patenkinamai");
        break;
    case 7:
        Console.WriteLine("vidutiniskai");
        break;
    case 8:
        Console.WriteLine("gerai");
        break;
    case 9:
        Console.WriteLine("labai gerai");
        break;
    case 10:
        Console.WriteLine("puikiai");
        break;
}

        Console.WriteLine("------------------------");


        var isvedamasRezultatas = pazymys switch
        {
            0 or 1 or 2 or 3 or 4 => "nepatenkinamai",
            5 => "silpnai",
            6 => "patenkinamai",
            7 => "vidutiniskai",
            8 => "gerai",
            9 => "labai gerai",
            10 => "puikiai",
        };
        Console.WriteLine(isvedamasRezultatas);




** Nemokama kava **
Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
- Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
- Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"



Console.WriteLine("iveskite perkamu kavos puodeliu skaiciu:");
int kavosPuodeliuSkaicius = Convert.ToInt32(Console.ReadLine());


if (kavosPuodeliuSkaicius > 3)
{
    Console.WriteLine("jums priklauso ");
}



Console.WriteLine("iveskite perkamu kavos puodeliu skaiciu:");


var kava = Convert.ToInt32(Console.ReadLine()) / 3;
Console.WriteLine(kava == 0 ?
    "Pirkejui nepriklauso nemokama kava" :
    $"Pirkejui priklauso {kava} nemokami puodeliai"
    );





** Piešingi skaičiai **
Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
- Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
- Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;





Console.WriteLine("Iveskite 1 sveika skaiciu:");
int skaicius1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 2 sveika skaiciu:");
int skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 3 sveika skaiciu:");
int skaicius3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 4 sveika skaiciu:");
int skaicius4 = Convert.ToInt32(Console.ReadLine());

if (skaicius1 && skaicius2 && skaicius3 && skaicius4 == 0) 



Console.WriteLine($"{skaicius1} -> {skaicius1/-1}; {skaicius2} -> {skaicius2 / -1};{skaicius3} -> {skaicius3 / -1};{skaicius4} -> {skaicius4 / -1}");


---------------------------------------------------------------

Console.WriteLine("Iveskite 1 sveika skaiciu:");
int skaicius1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 2 sveika skaiciu:");
int skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 3 sveika skaiciu:");
int skaicius3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite 4 sveika skaiciu:");
int skaicius4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(skaicius1 != 0 ? $"{skaicius1} -> {skaicius1 * -1}": $"0=> N/A") ;
Console.WriteLine(skaicius2 != 0 ? $"{skaicius2} -> {skaicius2 * -1}": $"0=> N/A");
Console.WriteLine(skaicius3 != 0 ? $"{skaicius3} -> {skaicius3 * -1}": $"0=> N/A");
Console.WriteLine(skaicius4 != 0 ? $"{skaicius4} -> {skaicius4 * -1}": $"0=> N/A");
---------------------------------------------------------------------------------



ŽAIDIMAS ATSPĖK SKAIČIŲ
- ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
- NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
- JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
- JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
- JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
*/






/*
 
var skaicius = 13;
Console.WriteLine("Atspekite skaiciu nuo 1 iki 20, 1 bandymas:");
int spejimas1 = Convert.ToInt32(Console.ReadLine());

if (skaicius == spejimas1)
{
    Console.WriteLine("teisingai");
}
if (skaicius > spejimas1)
{
    Console.WriteLine("skaicius yra didesnis");
}
if (skaicius < spejimas1)
{
    Console.WriteLine("skaicius yra mazesnis");
}
Console.WriteLine("2 bandymas:");
Console.WriteLine("3 bandymas:");
Console.WriteLine("4 bandymas:");
Console.WriteLine("5 bandymas:");
Console.WriteLine("6 bandymas:");



-----------------------------------------------------------------------








//*SKAIČIUOTUVAS *
//Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
//-Parašykite programą kuri į ekraną išves skaičių rezultatą
//- naudokite if
//- naudokite switch


    
Console.WriteLine("Iveskite pirmaji skaiciu:");
var skaicius1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Iveskite antraji skaiciu:");
var skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite matematine operacija:");
string operacija = Console.ReadLine();

Console.WriteLine();

if (operacija == "+")
{
    Console.WriteLine(skaicius1 + skaicius2);
}
else if (operacija == "-")
{
    Console.WriteLine(skaicius1 - skaicius2);
}
else if (operacija == "*")
{
    Console.WriteLine(skaicius1 * skaicius2);
}
else if (operacija == "/")
{
    Console.WriteLine(skaicius1 / skaicius2);
}

Console.WriteLine();

switch (operacija)
{
    case "+":
        Console.WriteLine($"{skaicius1+skaicius2}");
        break;
    case "-":
        Console.WriteLine($"{skaicius1-skaicius2}");
        break;
    case "*":
        Console.WriteLine($"{skaicius1*skaicius2}");
        break;
    case "/":
        Console.WriteLine($"{skaicius1/skaicius2}");
        break;
}







/*

*Trys draugai *
-Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
- Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
- Atspausdinti draugų amžiaus vidurkį
- Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
-Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
< Hint > ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
konstrukcijas kurias iki šiol išėjome.




Console.WriteLine("Iveskite pirmojo draugo varda:");
string vardas1 = Console.ReadLine();
Console.WriteLine("Iveskite pirmojo draugo amziu:");
int amzius1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Iveskite antrojo draugo varda:");
string vardas2 = Console.ReadLine();
Console.WriteLine("Iveskite antrojo draugo amziu:");
int amzius2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Iveskite treciojo draugo varda:");
string vardas3 = Console.ReadLine();
Console.WriteLine("Iveskite treciojo draugo amziu:");
int amzius3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
Console.WriteLine($"{vardas1} {amzius1}");
Console.WriteLine($"{vardas2} {amzius2}");
Console.WriteLine($"{vardas3} {amzius3}");

Console.WriteLine();
Console.WriteLine($"Draugu amziaus vidurkis - {(amzius1+ amzius2+ amzius3)/3}");


if (amzius1 < amzius2 && amzius1 < amzius3)
{
    Console.WriteLine($"jauniausias draugas - {vardas1}, jam {amzius1}");
}
else if (amzius2 < amzius3 && amzius2 < amzius1)
{
    Console.WriteLine($"jauniausias draugas - {vardas2}, jam {amzius2}");
}
else if (amzius3 < amzius1 && amzius3 < amzius2)
{
    Console.WriteLine($"jauniausias draugas - {vardas3}, jam {amzius3}");
}


if (amzius1 > amzius2 && amzius1 > amzius3)
{
    Console.WriteLine($"vyriausias draugas - {vardas1}, jam {amzius1}");
}
else if (amzius2 > amzius3 && amzius2 > amzius1)
{
    Console.WriteLine($"vyriausias draugas - {vardas2}, jam {amzius2}");
}
else if (amzius3 > amzius1 && amzius3 > amzius2)
{
    Console.WriteLine($"vyriausias draugas - {vardas3}, jam {amzius3}");
}





**Kalėdų sausainiai * *
-Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
-Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
-Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
- Jei nėra išveda - "Palaukite kalėdų"
Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
< Hint > metodai data.Month ir data.Day
*/


