using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Liczba
    {
        private int[] liczba;

        public Liczba(string napis)
        {
            int dlugosc = napis.Length;
            liczba = new int[dlugosc];
            for (int i = 0; i < dlugosc; i++)
            {
                liczba[i] = int.Parse(napis[i].ToString());
            }
        }
        public void wyswietl()
        {
            for (int i = 0; i < liczba.Length; i++)
            {
                Console.Write(liczba[i]);
            }
            Console.WriteLine();
        }
        public void mnozenie(int x)
        {
            int reszta = 0;
            for (int i = liczba.Length - 1; i >= 0; i--)
            {
                int wynik = liczba[i] * x + reszta;
                liczba[i] = wynik % 10;
                reszta = wynik / 10;
            }
            if (reszta > 0)
            {
                int[] tab = new int[liczba.Length + 1];
                tab[0] = reszta;
                for (int i = 1;  i <= tab.Length; i++)
                {
                    tab[i] = liczba[i-1];
                }
                liczba = tab;
            }
            wyswietl();
        }
        public void silnia(int n)
        {
            int silnia = 1; 
            for (int i = 2; i <= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine($"Silnia z {n} = {silnia}");
        }
    }
}
