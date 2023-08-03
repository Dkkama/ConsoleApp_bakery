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

        public Customer(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        } // void - returns

        public string FirstName { get; set; } // FirstName - property 
        public string LastName { get; set; }

        

    }
}
