namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            //zadanie2();
            //zadanie3();
            //zadanie4();
            //zadanie5();
            //zadanie6();
            //zadanie7();
        }

        static void zadanie1()
        {
            double a = inputDouble();
            double b = inputDouble();
            double c = inputDouble();
            double delta, x1, x2;

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazania w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                }
                else 
                {
                    x1 = -b - Math.Sqrt(delta) / (2 * a);
                    x2 = -b + Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine($"x1 = {x1} , x2 = {x2}");
                }
            }
            else Console.WriteLine("To nie jest równanie kwadratowe");
        }

        static void view()
        {
            Console.WriteLine("Podaj operacje:");
            Console.WriteLine("1.suma");
            Console.WriteLine("2.roznica");
            Console.WriteLine("3.iloczyn");
            Console.WriteLine("4.iloraz");
            Console.WriteLine("5.potega");
            Console.WriteLine("6.pierwiastek kwadratowy");
            Console.WriteLine("7.trygonometria");
            Console.WriteLine("8.wyjscie");
            Console.WriteLine("Twoj wybor");
        }

        static void viewzad3()
        {
            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1.wyswietl tablice od poczatku");
            Console.WriteLine("2.wyswietl tablice od konca");
            Console.WriteLine("3.wyswietl elementy o nieparzystym indeksie");
            Console.WriteLine("4.wyswietl elementy o parzystym indeksie");
            Console.WriteLine("5.wyjdz");
        }
        static void zadanie2()
        {
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                view();
                int operacja = Convert.ToInt32(Console.ReadLine());


                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        double a = inputDouble();
                        double b = inputDouble();
                        suma(a, b);
                        break;
                    case 2:
                        double c = inputDouble();
                        double d = inputDouble();
                        roznica(c, d);
                        break;
                    case 3:
                        double e = inputDouble();
                        double f = inputDouble();
                        iloczyn(e, f);
                        break;
                    case 4:
                        double g = inputDouble();
                        double h = inputDouble();
                        iloraz(g, h);
                        break;
                    case 5:
                        double i = inputDouble();
                        potega(i);
                        break;
                    case 6:
                        double j = inputDouble();
                        pierwiastek(j);
                        break;
                    case 7:
                        double k = inputDouble();
                        trygonometria(k);
                        break;
                    case 8:
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("domyslny"); break;

                }
            }
        }
        static void suma(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"Suma {a} + {b} = {sum}");
        }
        static void roznica(double a, double b)
        {
            double substraction = a - b;
            Console.WriteLine($"Różnica {a} - {b} = {substraction}");
        }
        static void iloczyn(double a, double b)
        {
            double multiplication = a * b;
            Console.WriteLine($"Iloczyn {a} * {b} = {multiplication}");
        }
        static void iloraz(double a, double b)
        {
            double division = a / b;
            Console.WriteLine($"Iloraz {a} oraz {b} = {division}");
        }
        static void potega(double a)
        {
            double exponentiation = Math.Pow(a,2);
            Console.WriteLine($"{a} do potęgi 2 = {exponentiation}");
        }
        static void pierwiastek(double a)
        {
            double element = Math.Sqrt(a);
            Console.WriteLine($"pierwiastek z {a} = {element}");
        }
        static void trygonometria(double a)
        {
            double rad = a * Math.PI / 180;
            Console.WriteLine("sinus kata " + a + " wynosi " + Math.Sin(rad));
            Console.WriteLine("cosinus kata " + a + " wynosi " + Math.Cos(rad));
            Console.WriteLine("tangens kata " + a + " wynosi " + Math.Tan(rad));

        }

        static double inputDouble()
        {
            Console.WriteLine("Podaj wartosc:");
            double a = Convert.ToDouble(Console.ReadLine());
            return a;

        }

        static void wyswietl(double[] tab)
        {
            //for (int i = 0; i < tab.Length; i++)
            //{
            //  Console.Write(tab[i] + " ");
            //
            //}
            foreach (int item in tab)
            {
                Console.Write(item + " ");
            }
        }

        static void wyswietlKoniec(double[] tab)
        {
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                Console.Write(tab[i] + " ");
            }
        }

        static void wyswietlNieParzyste(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 != 0)
                {
                    Console.Write(tab[i] + " ");
                }

            }

        }
        
        static void wyswietlParzyste(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                {
                    Console.Write(tab[i] + " ");
                }

            }
        }

        static void zadanie3()
        {
            double[] tab = new double[5];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = inputDouble();
            }
            while (true)
            {
                viewzad3();
                int wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 1) { wyswietl(tab); }
                else if (wybor == 2) { wyswietlKoniec(tab); }
                else if (wybor == 3) { wyswietlNieParzyste(tab); }
                else if (wybor == 4) { wyswietlParzyste(tab); }
                else if (wybor == 5) { Environment.Exit(0); }
            }
        }
        static void zadanie4()
        {
            double[] tablica = new double[10];
            for (int i = 0; i < 10; i++)
            {
                tablica[i] = inputDouble();
            }
            sumaIloczynSrednia(tablica);
            wartosciMinMax(tablica);
        }
        static double sumaIloczynSrednia(double[] tab ) 
        {
            double suma = 0;
            double mnozenie = 1;
            double srednia = 0;

            foreach (double item in tab)
            {
                suma +=  item;
                mnozenie = mnozenie * item;
            }
            srednia = suma / tab.Length;
            Console.WriteLine($"Suma elementow tablicy to: {suma}");
            Console.WriteLine($"Srednia elementow tablicy to: {srednia}");
            Console.WriteLine($"Iloczyn elmentow tablicy to: {mnozenie}");
            return suma;
        }

        static void wartosciMinMax(double[] tab) 
        {
            double min = 0, max = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (i == 0) 
                {
                    min = tab[i];
                    max = tab[i];       
                }
                else
                {
                    if (tab[i] < min) 
                    {
                        min = tab[i];
                    }
                    if (tab[i] > max) 
                    {
                        max = tab[i];
                    }
                }
             
            }
            Console.WriteLine($"Najmniejsza wartoscia w tablicy jest {min} , a najwieksza {max}");
        }
        static void zadanie5()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void zadanie6()
        {
            int x = new int();
            while (true)
            {
                Console.WriteLine("Podaj liczbe calkowita: ");
                 x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
            }
        }
        static void zadanie7()
        {
            Console.WriteLine("Podaj ile liczb chcesz wprowadzic: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tablica = new double[n];
            for (int i = 0; i < n; i++)
            {
                tablica[i] = inputDouble();
            }
            Console.WriteLine("Tablica nieposortowana");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tablica[i]);
            }


            sortowanieBabelkowe(tablica, n);
        }
        static void sortowanieBabelkowe(double[] tab, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - (1 + i); j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        (tab[j + 1], tab[j]) = (tab[j], tab[j + 1]);
                    }
                }
            }
            Console.WriteLine("Tablica posortowana: ");
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}