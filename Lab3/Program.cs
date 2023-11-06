namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            /*
            Licz[] liczby = new Licz[5];
            liczby[0] = new Licz(4);
            liczby[1] = new Licz(1);
            liczby[2] = new Licz(6);
            liczby[3] = new Licz(7);
            liczby[4] = new Licz(8);
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine(liczby[i].Dodaj(1));
                Console.WriteLine(liczby[i].Odejmij(1));
                Console.WriteLine();
            }
            */
            //zad2
            /*
            double[] doTestu = { 5, 10, 65, -14, 99 };
            Sumator test = new Sumator(doTestu);
            test.wypisz();
            Console.WriteLine($"Suma elementów podzielnych przez 2: {test.SumaPodziel2()}");
            Console.WriteLine($"Liczba elementów: {test.ileElementow()}");
            Console.WriteLine($"Suma elementów: {test.Suma()}");
            */
            //zad3
            /*
            Data teraz = new Data();
            teraz.WyswietlBiezaca();
            teraz.WyswietlMinus7();
            teraz.WyswietlPlus7();
            */
            //zad4
            Liczba proba = new Liczba("1020");
            proba.wyswietl();
            proba.mnozenie(6);
            proba.silnia(6);

        }
    }
}