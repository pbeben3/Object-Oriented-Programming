using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private string nadwozie;
        private string kolor;
        private string data;
        private int przebieg;
        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Nadwozie { get {  return nadwozie; } set {  nadwozie = value; } }
        public string Kolor { get {  return kolor; } set {  kolor = value; } }
        public string Data { get { return data; } set { data = value; } }
        public int Przebieg { get {  return przebieg; } set {  przebieg = value; } }

        public Samochod()
        {
            Console.WriteLine("Podaj marke"); ;
            string marka = Console.ReadLine();
            Console.WriteLine("Podaj model:");
            string model = Console.ReadLine();
            Console.WriteLine($"Podaj rodzaj nadwozia:");
            string nadwozie = Console.ReadLine();
            Console.WriteLine($"Podaj kolor:");
            string kolor = Console.ReadLine();
            Console.WriteLine($"Podaj date produkcji:");
            string data = Console.ReadLine();
            Console.WriteLine($"Podaj przebieg:");
            int przebieg = Convert.ToInt32(Console.ReadLine());
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            Data = data;
            if (przebieg < 0)
            {
                Przebieg = 0;
            }
            else
            {
                Przebieg = przebieg;
            }
            
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, string data, int przebieg)
        {
            this.marka = marka;
            this.model = model;
            this.nadwozie = nadwozie;
            this.kolor = kolor;
            this.data = data;
            if (przebieg < 0)
            {
                this.przebieg = 0;
            }
            else
            {
                this.przebieg = przebieg;
            }
        }

        public void view()
        {
            Console.WriteLine($"Marka: {marka} \tmodel: {model} \tnadwozie; {nadwozie} \t kolor: {kolor} \tdata produkcji: {data} \tprzebieg: {przebieg}");
        }
    }
}
