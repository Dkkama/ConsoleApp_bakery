using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cupcake : Confectionary
    {
        public Cupcake(int calories, string flavour, string ingrediants) {
            Calory = calories;
            Flavour = flavour;
            Ingrediants = ingrediants;
        }

        public string Ingrediants { get; set; }
        
    }
}
