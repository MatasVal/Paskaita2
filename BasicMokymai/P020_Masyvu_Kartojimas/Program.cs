﻿namespace P020_Masyvu_Kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvu kartojimas!");
                     

        }

        //      ## Rasti mažiausią ##
        //Duotas vienatis sveikų skaičių masyvas.
        //Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
        //{ 5, 3, 7, 6, 8, 7, 10 }
        //rezultatas:  3

        public static int RastiMaziausia(int[] mas)
        {
            int maziausias = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if(maziausias > mas[i])
                {
                    maziausias = mas[i];
                }
            } 
            return maziausias;
        }
        // 2. ## Rasti didžiausią ##
        //Duotas vienatis sveikų skaičių masyvas.
        //Parašykite programą, kuri į ekraną išves didziausia skaičių masyve
        // { 5, 3, 7, 6, 8, 7, 10 }
        // rezultatas:  10
        public static int RastiDidziausia(int[] mas)
        {
            int didziausias = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (didziausias < mas[i])
                {
                    didziausias = mas[i];
                }
            }
            return didziausias;
        }
       // 3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
       //Duotas vienmatis sveikų skaičių masyvas.
       //Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo
       // mažiausio iki didžiausio
       // { 5, 1, 7, 6, 8, 7, 10 }

       // rezultatas:  1, 5, 6, 7, 7, 8, 10

        public static int[] SurikiuotiDidejimoTvarka(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        //## RIKIUOTI TRIS RAIDES ##
        //        Parašykite programą kurioje vienas metodas.
        //  - Naudotojo paprašome įvesti 3 raides(atskirai).
        //    Būtina validacija kad įvesta tik vienas simbolis.
        //  - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
        //  Pvz:
        //  > Iveskite pirma raide:
        //  _ C
        //  > Iveskite antra raide:
        //  _ D
        //  > Iveskite trecia raide:
        //  _ B
        //  >  B, C, D

        //public static char[] SurikiuotosRaides(char[] mas)
        //{
        //    Console.WriteLine("Iveskite pirmaja raide:");
        //    var char1 = Console.Read();            
        //    Console.WriteLine("Iveskite antraja raide:");
        //    var char2 = Console.Read();            
        //    Console.WriteLine("Iveskite treciaja raide:");
        //    var char3 = Console.Read();
                     
        //    for (int i = 0; i < mas.Length; i++)
        //    {
        //            for (int j = i + 1; j < mas.Length; j++)
        //            {
        //                if (mas[i] > mas[j])
        //                {
        //                    int temp = mas[i];
        //                    mas[i] = mas[j];
        //                    mas[j] = temp;
        //                }
        //            }
        //    }


        //        return mas;
            

        //}

        public static char[] RikiuotiTrisRaides(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        char temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        //## RIKIUOTI KETURIAS RAIDES ##
        //        Parašykite programą kurioje vienas metodas.
        //            - Naudotojo paprašome įvesti 4 raides(atskirai).
        //              Būtina validacija kad įvesta tik vienas simbolis.
        //            - Metodas priima masyvą iš string (su prielaidai kad kiekvienas string yra tik 1 raide)
        //              ir grąžina string (NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -.
        //            Pvz:
        //            > Iveskite pirma raide:
        //            _ C
        //            > Iveskite antra raide:
        //            _ A
        //            > Iveskite trecia raide:
        //            _ B
        //            > Iveskite ketvirtą raide:
        //            _ E
        //            > A-B-C-E

        public static string RikiuotiKeturiasRaides(string[] raides)
        {
            char[] charMas = new char[raides.Length];

            for (int i = 0; i < raides.Length; i++)
            {
                charMas[i] = raides[i][0];
            }


            RikiuotiTrisRaides(charMas);
            //charMas = RikiuotiTrisRaides(charMas);  //priskyrimas nebutinas -----tai nera primityvus tipas, tai yra reference tipas, tai referena pagal defaulta

            //for (int i = 0; i < charMas.Length; i++)
            //{
            //    for (int j = i + 1; j < charMas.Length; j++)
            //    {
            //        if (charMas[i] > charMas[j])
            //        {
            //            char temp = charMas[i];
            //            charMas[i] = charMas[j];
            //            charMas[j] = temp;
            //        }
            //    }
            //}

            return String.Join("-", charMas);
        }



    }

}