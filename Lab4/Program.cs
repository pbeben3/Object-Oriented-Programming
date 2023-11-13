namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person mickiewicz = new Person("Adam", "Mickiewicz", 50);
            Person prus = new Person("Bolesław", "Prus", 60);
            Person sienkiewicz = new Person("Henryk", "Sienkiewicz", 40);
            Book PanTadeusz = new Book("Pan Tadeusz", "1834", mickiewicz);
            Book Lalka = new Book("Lalka", "1887", prus);
            Book Potop = new Book("Pan Tadeusz", "1886", sienkiewicz);
            //mickiewicz.view();
            //PanTadeusz.viewB();
            //Lalka.viewB();
            //Potop.viewB();
            
            Reader czytelnik1 = new Reader("Jan", "Kowalski", 35);
            czytelnik1.addBook(Lalka);
            czytelnik1.addBook(PanTadeusz);
            czytelnik1.viewBook();
            Reader czytelnik2 = new Reader("Paweł", "Bator", 45);
            czytelnik2.addBook(Potop);
            czytelnik2.viewBook();
            czytelnik1.View();


        }
    }
}