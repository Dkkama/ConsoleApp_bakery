using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Customer
    {
        /*private string firstname; // field
        public string Firstname; // property- combination of a variable and a method */

        public Customer(string firstname, string lastname, int numCake, int numCup)
        {
            FirstName = firstname;
            LastName = lastname;
 
            NumCake = numCake;
            NumCup = numCup;
        } // void - doesnt return

        public string FirstName { get; set; } // FirstName - property 
        public string LastName { get; set; }

        public int NumCake { get; set; }
        public int NumCup { get; set;}

    }
}
