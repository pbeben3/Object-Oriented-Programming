namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod();
            auto.view();
            Samochod auto2 = new Samochod("Toyota","Rav 4","SUV","zielony","10.10.2005",150000);
            auto2.view();
            SamochodOsobowy peugeot = new SamochodOsobowy(2500,3000,5,"Peugeot","307","hatchback","niebieski","05.05.2003",200000);
            peugeot.view();
        }

    }
}