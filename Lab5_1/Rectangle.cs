using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Rysuje kwadrat");
        }
    }
}
