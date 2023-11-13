using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4_1
{
    internal class SamochodOsobowy : Samochod
    {
        private int waga;
        private int pojemnosc;
        private int iloscosob;
        public int Waga { get { return waga; } set {  waga = value; } }
        public int Pojemnosc { get {  return pojemnosc; } set {  pojemnosc = value; } }
        public int Iloscosob { get {  return iloscosob; } set {  iloscosob = value; } }

        public SamochodOsobowy(int waga, int pojemnosc, int iloscosob, string marka, string model, string nadwozie, string kolor, string data, int przebieg)
            : base(marka, model, nadwozie, kolor, data, przebieg) 
        {
            this.pojemnosc = pojemnosc;
            this.iloscosob = iloscosob;
            if (waga < 2000)
            {
                this.waga = 2000;
            }
            else if (waga >4500)
            {
                this.waga = 4500;
            }
            else
            {
                this.waga = waga;
            }
            if (pojemnosc < 800)
            {
                this.pojemnosc = 800;
            }
            else if (pojemnosc > 3000)
            {
                this.pojemnosc = 3000;
            }
            else
            {
                this.pojemnosc = pojemnosc;
            }
            if (iloscosob < 0)
            {
                this.iloscosob = 2;
            }
            else if (iloscosob > 9)
            {
                this.iloscosob = 9;
            }
            else
            {
                this.iloscosob = iloscosob;
            }
        }
        public new void view()
        {
            Console.WriteLine($"Marka: {Marka} \tmodel: {Model} \tnadwozie; {Nadwozie} \t kolor: {Kolor} \tdata produkcji: {Data} \tprzebieg: {Przebieg} \twaga: {waga} \tpojemność: {pojemnosc} \tilość miejsc: {iloscosob}");
        }

    }
}
