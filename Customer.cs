using System;
using System.Collections;
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

        public Customer(string firstname, string lastname, object orderArray)
        {
            FirstName = firstname;
            LastName = lastname;

            var orders = new List<object> { orderArray };
        } // void - doesnt return

        public string FirstName { get; set; } // FirstName - property 
        public string LastName { get; set; }



    }
}
