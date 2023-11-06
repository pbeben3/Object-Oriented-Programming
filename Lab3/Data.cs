using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Data
    {
        private DateTime data;

        public Data()
        {
            data = DateTime.Now;
        }
        public void WyswietlBiezaca()
        {
            Console.WriteLine(data);
        }
        public void WyswietlPlus7()
        {
            DateTime dataplus = data.AddDays(7);
            Console.WriteLine(dataplus);
        }
        public void WyswietlMinus7()
        {
            DateTime dataminus = data.AddDays(-7);
            Console.WriteLine(dataminus);
        }
    }
}
