using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Sumator
    {
        private double[] Liczby = { };

        public Sumator(double[] Liczby) 
        { 
            this.Liczby = Liczby;
        }
        
        public double Suma()
        {
            double suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                suma += Liczby[i];
            }
            return suma;
        }
        public double SumaPodziel2()
        {
            double sumaPodzielnych = 0;
            for (int i = 0;i < Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0)
                { 
                    sumaPodzielnych += Liczby[i];
                }
            }
            return sumaPodzielnych;
        }
        public int ileElementow()
        {
            int ilosc = Liczby.Length;
            return ilosc;
        }
        public void wypisz()
        {
            for (int i = 0; i < Liczby.Length  ; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
        public void lowHigh(int lowIndex, int highIndex)
        {
            if (lowIndex > Liczby.Length)
            {
                Console.WriteLine($"W tablicy nie ma elementów o indeksie większym niż{lowIndex}");
            }
            else if (lowIndex < 0)
            {
                for (int i = 0; i < Liczby.Length; i++)
                {
                    Console.WriteLine(Liczby[i]); 
                }
            }
            else
            {
                for(int i = lowIndex; i < Liczby.Length ; i++)
                {
                    Console.WriteLine(Liczby[i]);
                }
            }

            if (highIndex > Liczby.Length)
            {
                for (int i = Liczby.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(Liczby[i]);
                }
            }
            else if (highIndex < 0)
            {
                Console.WriteLine($"W tablicy nie ma elementów o indeksie mniejszym niż {highIndex}");
            }
            else
            {
                for ( int i = highIndex; i >= 0; i--)
                {
                    Console.WriteLine(Liczby[i]);
                }
            }
        }
    }
}
