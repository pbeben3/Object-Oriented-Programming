using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public void ZwrocPelnaNazwe()
        {
            Console.WriteLine($"P{Imie} {Nazwisko}");
        }
    }
}
