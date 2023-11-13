using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Book
    {
        private string title;
        private string dataWydania;
        Person author;
        public string Title { get { return title; } set {  title = value; } }
        public string DataWydania { get {  return dataWydania; } set {  dataWydania = value; } }

        public Book(string title, string dataWydania, Person author)
        {
            this.title = title;
            this.dataWydania = dataWydania;
            this.author = author;
        }
        public void viewB()
        {
            Console.WriteLine($"Tytuł:{title} \tData Wydania: {dataWydania} \tAutor: {author.FirstName} {author.LastName}");
        }
    }
}
