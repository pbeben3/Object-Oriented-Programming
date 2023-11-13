using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Reader : Person
    {
        List <Book> przeczytane = new List <Book> ();
        public Reader (string firstName, string lastName, int wiek)
            :base (firstName, lastName, wiek) { }
        
        public void addBook(Book ksiazka)
        {
            przeczytane.Add (ksiazka);
        }
        public void viewBook()
        {
            for (int i = 0; i < przeczytane.Count; i++)
            {
                Console.Write($"{przeczytane[i].Title}, ");
            }
            Console.WriteLine();
        }
        public void View()
        {
            Console.Write($"Imie: {FirstName} \tNazwisko: {LastName} \tWiek: {Wiek} \tprzeczytał: ");
            viewBook();
            Console.WriteLine();
        }
    }
}
