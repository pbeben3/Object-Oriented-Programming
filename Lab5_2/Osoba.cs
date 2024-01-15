
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Osoba
    {
        private string Imie;
        private string Nazwisko;
        private string Pesel;

        public virtual void SetFirstName(string name)
        {
            this.Imie = name;
        }

        public virtual void SetLastName(string lastName)
        {
            this.Nazwisko = lastName;
        }
        public virtual void SetPesel(string pesel)
        {
            this.Pesel = pesel;
        }
        public virtual int GetAge()
        {
            int year = Convert.ToInt32(Pesel.Substring(0,2));
            int age = DateTime.Now.Year - (1990 + year);
            return age;
        }
        public virtual void GetGender()
        {
            int plec = Convert.ToInt32((Pesel.Substring(9, 1)));
            if (plec % 2 == 0)
            {
                Console.WriteLine("kobieta");
            }
            else
            {
                Console.WriteLine("męszczyzna");
            }
        }
        public virtual void GetEducationInfo()
        {
            Console.WriteLine("wykształcenie: ");
        }
        public virtual void GetFullName()
        {
            Console.WriteLine($"{Imie} {Nazwisko}");
        }
        public virtual bool CanGoHomeAlone() 
        { 
            return false;
        }
    }

}
