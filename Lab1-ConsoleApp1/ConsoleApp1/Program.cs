using System;
using System.Threading;
/*
1. Sa se construiasca un tip (clasa) ce expune un eveniment. Scrieti codul ce exemplifca folosirea
acestui tip.
2. Determinati cel mai mare numar prim mai mic decat un numar natural dat. Identificati cel putin
doua metode (doi algoritmi). Fiecare metoda va fi apelata pe fire distincte. Fiecare fir va folosi o
resursa comuna – lista in cazul nostru sau orice altceva ce considerati Dv – in care vor insera
urmatoarele informatii:
a. “Start fir: “ + nume fir + Timestamp + “ Numar natural dat = “ + numarNaturalDat.
Timestamp sub forma hh:mm:s:ms
b. “Iesire temporara fir: “ + nume fir + Timestamp. Se intampla cand firul este intrerupt de
catre SO si se lanseaza alt fir de executie.
c. “End fir: “ + nume fir + Timestamp + “Numar prim = “ + numarPrimDeterminat. . Firul sia terminat executia si afiseaza rezultatul final.
3. Aceeasi problema ca la punctul doi dar veti folosi componenta BackgroundWorker.
4. Aceeasi problema ca la punctul 2 dar veti folosi patternul TAP (Task Asyncronous Pattern).
*/
namespace Lab1
{
    class Program
    {
        static bool IsPrime1(int nr)
        {
            if (nr == 2 || nr == 3 || nr == 5)
                return true;

            for (int i = 2; i <= nr / 2; i++)
            {
                if (nr % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPrime2(int nr)
        {
            if (nr % 2 == 0)
                return false;
            for(int i = 3; i <= nr/2; i+=2)
            {
                if(nr % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Metoda1(int nr)
        {
            for (int i = nr - 1; i >= 2; i--)
            {
                if (IsPrime1(i) == true)
                {
                    Console.WriteLine(i);
                    i = 0; 
                }
                    
            }
        }

        public static void Metoda2(int nr)
        {
            
            for(int i = nr-1; i >= 2; i-=1)
            {
                if (IsPrime2(i) == true)
                {
                    Console.WriteLine(i);
                    i = 0;
                }
                    
            }
        }

        static void Main(string[] args)
        {
            int numar = 100;
            Program obj = new Program();
            Thread t1 = new Thread(() => Metoda1(numar));
            Thread t2 = new Thread(() => Metoda2(numar));

            t1.Name = "primul fir";
            t2.Name = "al doilea fir";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            // Console.WriteLine(obj.Metoda1(numar));
            // Console.WriteLine(obj.Metoda2(numar));

            // Metoda1(numar);
            // Console.WriteLine("Hello World!");
        }

    }
}
