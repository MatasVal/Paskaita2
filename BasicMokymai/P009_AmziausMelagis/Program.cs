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
Console.WriteLine("Prasome ivesti savo asmens koda (11 simb.):");
int asmensKodas = Convert.ToInt32(Console.ReadLine());

