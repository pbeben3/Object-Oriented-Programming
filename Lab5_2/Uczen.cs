using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class Uczen : Osoba
    {
        public string Szkoła { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }
        public void SetSchool(string szkola)
        {
            this.Szkoła = szkola;
        }
        public void ChangeSchool(string nowaszkola)
        {
            if (Szkoła != "")
            {
                Console.WriteLine($"Szkoła zmieniona z {Szkoła} na {nowaszkola}");
                this.Szkoła = nowaszkola;
            }
            else
            {
                Console.WriteLine("Nie można zmienić szkoły ponieważ ten uczeń nie ma żadnej przypisanej");
            }
        }
        public void SetCanGoHomeAlone (bool moze)
        {
            MozeSamWracacDoDomu = moze;
        }
        public override bool CanGoHomeAlone()
        {
            if (MozeSamWracacDoDomu == true || GetAge() >= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void SetFirstName(string name)
        {
            base.SetFirstName(name);
        }
        public override void SetLastName(string lastName)
        {
            base.SetLastName(lastName);
        }
        public override void SetPesel(string pesel)
        {
            base.SetPesel(pesel);
        }
        public override int GetAge()
        {
            return base.GetAge();
        }
        public override void GetGender()
        {
            base.GetGender();
        }
        public override void GetEducationInfo()
        {
            base.GetEducationInfo();
        }
        public override void GetFullName()
        {
            base.GetFullName();
        }

    }
}
