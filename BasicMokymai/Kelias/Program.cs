
//2.PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H).

Console.WriteLine("Prasome ivesti atstuma tarp tasku A ir B (km):");
int atstumasTarpAirB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prasome ivesti transporto priemones A greiti (km/h):");
int greitisA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prasome ivesti transporto priemones B greiti (km/h):");
int greitisB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//VIENA TRANSPORTO PRIEMONĖ PRADEDA VAŽIUOTI IŠ A, KITA IŠ B. STARTUOJA VIENU METU.
//- PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUSITIKS METRAIS.

Console.WriteLine("Transporto priemones susitiks:");
Console.WriteLine();
int atstumasIkiA = 0;
int atstumasIkiB = atstumasTarpAirB; //B lygus atstumui tarp A ir B, nes A = 0

int susitikimoLaikasA = atstumasTarpAirB / greitisA;
int susitikimoLaikasB = atstumasTarpAirB / greitisB;

int susitikimoAtstumasNuoA = (susitikimoLaikasA + susitikimoLaikasB = atstumasTarpAirB) *1000;  //*1000, nes metrais //"= atstumasTarpAirB", nes kai suma bus lygi "atstumasTarpAirB", tp. priemones susitiks


Console.WriteLine($"Transporto priemones susitiks {susitikimoAtstumasNuoA} m nuo tasko A");


//Console.WriteLine($"Transporto priemones susitiks {} m nuo tasko A");


// - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS.

Console.WriteLine();

// - PASKAIČIUOTI LAIKĄ, KADA TRASPORTO PRIEMONĖS PASIEKS GALUTINIUS TAŠKUS MINUTĖMIS.

Console.WriteLine();

// - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRANSPORTO PRIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.

Console.WriteLine();


// - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
//   A) PARODYTI VISO KELIO ILGĮ KM
//   B) PARODYTI SEGMENTO ILGĮ KM
// C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
//  D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
//  if naudoti negalima, ternary operator (?) naudoti negalima, ciklų naudoti negalima






/* REZULTATAS GALI ATRODYTI TAIP:


   | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km | 5km |
   |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
  _A______ | ______ | ______ | ___V___ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______B_
   | -----------22km-------- -|
   | ----------------------------------------------------------------100km---------------------------------------------------------------------- -|
   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 90min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
   <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< 30min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
*/



