using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Licz
    {
        private double value = 0;
        public double Dodaj(double a)
        {
            value = value += a;
            return value;
        }
        public double Odejmij(double a)
        {
            value = value - a;
            return value;
        }
        public Licz(double a)
        {
            value = a;
        }
        public void wypisz()
        {
            Console.WriteLine("wartosc wynosi" + value);
        }
    }
}
