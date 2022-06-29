

Console.WriteLine("Prasome ivesti savo varda ir pavarde:");
string vardasPavarde = Console.ReadLine();
Console.WriteLine();



Console.WriteLine("Prasome ivesti savo asmens koda (11 simb.):");
var asmensKodoIvestis = Console.ReadLine();
long asmensKodas;
bool arAsmensKodasYraSkaicius = long.TryParse(asmensKodoIvestis, out asmensKodas); 
//patikrinu ar asmens kodas yra skaicius



if (arAsmensKodasYraSkaicius) 
{
        if (asmensKodas < 10000000000)
        {
        Console.WriteLine("Ivestas per mazas skaitmuo");
        Environment.Exit(0);
        }
        else if (asmensKodas > 69999999999)
        {
        Console.WriteLine("Ivestas per didelis skaitmuo");   //jeigu ivestas asm. kodas yra skaicius, tikrinu ar ji sudaro tinkamas kiekis skaitmenu ir, ar jis neiseina is asmens kodo ribu
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

string amziausIvestis = Console.ReadLine();

bool arAmziusYraIvestas = int.TryParse(amziausIvestis, out int amzius);// tikrinu ar amzius yra ivestas


Console.WriteLine();

Console.WriteLine("Prasome ivesti savo gimimo data:");



var gimimoDataIvestis = Console.ReadLine();

bool arGimimoDataYraIvesta = DateTime.TryParse(gimimoDataIvestis, out DateTime gimimoData);

string gimimoDataSuformatuota = gimimoData.ToString("yyyy-MM-dd"); //pasidarau kintamaji kuris yra suformatuota gimimo data



Console.WriteLine();

var siandienosDataSuformatuota = DateTime.Now.ToString("yyyy-MM-dd");

string lytis = (asmensKodas >= 10000000000 && asmensKodas <= 19999999999 || asmensKodas >= 30000000000 && asmensKodas <= 39999999999 || asmensKodas >= 50000000000 && asmensKodas <= 59999999999) ? "Vyras" : "Moteris";

string asmensKodasString = asmensKodas.ToString();

string isAsmensKodoIskirptaGimimoData = asmensKodasString.Substring(1, 6);
string asmensKodoPirmasisSkaitmuo = asmensKodasString.Substring(0, 1);

//jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu.
//  a) jei sutampa išvesti "amžius patikimas"
//  b) jei nesutampa išvesti "amžius pameluotas"

var einamiejiMetai = DateTime.Now.ToString("yyyy");

int einamiejiMetaiInt = Convert.ToInt32(einamiejiMetai);

var gimimoMetaiIsAmziaus = einamiejiMetaiInt - (amzius+1);

string gimimoMetaiIsAmziausString = Convert.ToString(gimimoMetaiIsAmziaus);

//Is asmens kodo issivesta gimimo data

string issivestaGimimoData19amzius = ("18" + isAsmensKodoIskirptaGimimoData); //jei asm kodas prasideda vienetu, tai zmogus gimes 18** metais, pridedu "18" prie trumpintos gim datos
string issivestaGimimoData20amzius = ("19" + isAsmensKodoIskirptaGimimoData);
string issivestaGimimoData21amzius = ("20" + isAsmensKodoIskirptaGimimoData);
string issivestaGimimoDataSuBruksniais19amzius = issivestaGimimoData19amzius.Insert(4, "-").Insert(7, "-");
string issivestaGimimoDataSuBruksniais20amzius = issivestaGimimoData20amzius.Insert(4, "-").Insert(7, "-");
string issivestaGimimoDataSuBruksniais21amzius = issivestaGimimoData21amzius.Insert(4, "-").Insert(7, "-");
string issivestiGimimoMetai19amzius = issivestaGimimoData19amzius.Substring(0, 4);
string issivestiGimimoMetai20amzius = issivestaGimimoData20amzius.Substring(0, 4);
string issivestiGimimoMetai21amzius = issivestaGimimoData21amzius.Substring(0, 4);
string amziausPatikimumas= "";


//jei amzius ivestas, ziurima koks pirmas skaicius ir nuo to priklausomai pridedamas amzius prie nepilnos gimimo datos issivestos is asmens kodo,
//Gauta papildyta data lyginama su gauta data skaiciuojant nuo ivesto amziaus ir, priklausomai nuo to ar datos sutampa yra isvedamas patikimumas



if (arAmziusYraIvestas)
{
    if (asmensKodoPirmasisSkaitmuo == "1" || asmensKodoPirmasisSkaitmuo == "2")
    {

        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai19amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "3" || asmensKodoPirmasisSkaitmuo == "4")
    {
        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai20amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "5" || asmensKodoPirmasisSkaitmuo == "6")
    {
        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai21amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
}

//Jei ivesta gimimo data ji yra lyginama su asmens kodu

if (arGimimoDataYraIvesta)
{
    if (asmensKodoPirmasisSkaitmuo == "1" || asmensKodoPirmasisSkaitmuo == "2")
    {

        if (gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais19amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "3" || asmensKodoPirmasisSkaitmuo == "4")
    {
        if (gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais20amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "5" || asmensKodoPirmasisSkaitmuo == "6")
    {
        if (gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais21amzius)
        {
            amziausPatikimumas = "amzius patikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
}

//jei įvestas ir amžius ir gimimo data sulyginti su įvestu asmens kodu

if (arGimimoDataYraIvesta && arAmziusYraIvestas)
{
    if (asmensKodoPirmasisSkaitmuo == "1" || asmensKodoPirmasisSkaitmuo == "2")
    {

        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai19amzius && gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais19amzius)
        {
            amziausPatikimumas = "amzius tikras";
        }
        else if (gimimoMetaiIsAmziausString == issivestiGimimoMetai19amzius || gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais19amzius)
        {
            amziausPatikimumas = "amzius nepatikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "3" || asmensKodoPirmasisSkaitmuo == "4")
    {
        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai20amzius && gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais20amzius)
        {
            amziausPatikimumas = "amzius tikras";
        }
        else if (gimimoMetaiIsAmziausString == issivestiGimimoMetai20amzius || gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais20amzius)
        {
            amziausPatikimumas = "amzius nepatikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
    else if (asmensKodoPirmasisSkaitmuo == "5" || asmensKodoPirmasisSkaitmuo == "6")
    {
        if (gimimoMetaiIsAmziausString == issivestiGimimoMetai21amzius && gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais21amzius)
        {
            amziausPatikimumas = "amzius tikras";
        }
        else if (gimimoMetaiIsAmziausString == issivestiGimimoMetai21amzius || gimimoDataSuformatuota == issivestaGimimoDataSuBruksniais21amzius)
        {
            amziausPatikimumas = "amzius nepatikimas";
        }
        else
        {
            amziausPatikimumas = "amzius pameluotas";
        }
    }
}

// jei neįvestas nei amžius nei gimimo data

if (!arGimimoDataYraIvesta && !arAmziusYraIvestas)
{
    amziausPatikimumas = "patikimumui trūksta duomenų";
}

if (!arGimimoDataYraIvesta)
{
    gimimoDataSuformatuota = "neivesta";
}

string amziusString = Convert.ToString(amzius);

if (!arAmziusYraIvestas)
{
    amziusString = "neivesta";
}

Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {siandienosDataSuformatuota,10}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓     Vardas, pavardė ▓ {vardasPavarde,-30}      ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓               Lytis ▓ {lytis,-7}                             ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓        Asmens kodas ▓ {asmensKodas,11}                         ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓              Amžius ▓ {amziusString,-8}                            ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓         Gimimo data ▓ {gimimoDataSuformatuota,-10}                          ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amžiaus patikimumas ▓ {amziausPatikimumas,-30}      ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");