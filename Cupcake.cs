using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cupcake
    {
        public Cupcake(string calories, string flavour, string ingrediants) {
            Calory = calories;
            Flavour = flavour;
            Ingrediants = ingrediants;
        }

        public string Calory { get; set; }
        public string Flavour { get; set; }
        public string Ingrediants { get; set; }
        
    }
}
