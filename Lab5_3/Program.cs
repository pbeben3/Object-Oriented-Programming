namespace Lab5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba {Imie = "Jan", Nazwisko = "Kowalski" });
            osoby.Add(new Osoba { Imie = "Robert", Nazwisko = "Lewandowski" });
            osoby.Add(new Osoba { Imie = "Adam", Nazwisko = "Małysz" });

        }
    }
}