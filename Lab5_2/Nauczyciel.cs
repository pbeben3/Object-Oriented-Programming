using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> podwladni { get; set; }
        void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {

            Console.WriteLine($"Data: {dateToCheck}\nUczniowie mogący iść sami do domu:");
            foreach (Uczen uczen in podwladni)
            {
                if (uczen.CanGoHomeAlone() == true)
                {
                    uczen.GetFullName();
                }
            }
        }
    }
}
