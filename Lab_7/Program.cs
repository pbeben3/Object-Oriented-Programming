namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1

            //using (var sw = new StreamWriter("zad1.txt"))
            //{
            //    Console.WriteLine("Podaj numer albumu: ");
            //    string nrAlbumu = Console.ReadLine();
            //    sw.WriteLine(nrAlbumu);
            //    Console.WriteLine("Twój numer albumu został zapisany");
            //}

            //zad 2
            //using (var sw = new StreamReader("zad1.txt"))
            //{
            //    var zawartosc = sw.ReadToEnd();
            //    Console.WriteLine(zawartosc);
            //}

            //zad3
            //SprawdzPlec();

        }

        public static void SprawdzPlec()
        {
            int liczbaKobiet = 0;
            using (var sr = new StreamReader("pesels.txt"))
            {
                string pesel;
                while ((pesel = sr.ReadLine()) != null)
                {
                    int x = Int32.Parse(pesel.Substring(10));
                    if (x % 2 == 0)
                    {
                        liczbaKobiet = liczbaKobiet + 1;
                    }
                }
            }
            Console.WriteLine($"Liczba żeńskich peseli na liście to {liczbaKobiet}");
        }
    }
}