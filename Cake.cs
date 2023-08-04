using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cake
    {
        public Cake(int calories, string flavour)
        {
            Calory = calories;
            Flavour = flavour;
        }

        public int Calory { get; set; }
        public string Flavour { get; set; }

    }
}
