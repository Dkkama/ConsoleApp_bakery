using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FileStream fileStr = File.Create(pathName); // Create()

            string pathName = "C:\\Users\\Sulpak\\source\\repos\\ConsoleApp1\\ConsoleAppProject\\myFile.txt";

            Console.WriteLine("Name: ");
            string custName = Console.ReadLine();

            Console.WriteLine("Last name: ");
            string custLast = Console.ReadLine();
            Customer customer = new Customer(custName, custLast);

            Console.WriteLine("What do u prefer? Cake - 1; Cupcake - 2 ");
            int sweet = int.Parse(Console.ReadLine());
            if (sweet == 1)
            {
                Console.WriteLine("Calories: ");
                string cakeCal = Console.ReadLine(); // int cakeCal = int.Parse(Console.ReadLine()); 

                Console.WriteLine("Flavour: ");
                string cakeFlav = Console.ReadLine();
                Cake cake = new Cake(cakeCal, cakeFlav); // obj cake is created

                File.WriteAllText(pathName, string.Join("; ", (customer.FirstName, customer.LastName, cake.Calory, cake.Flavour)));
            }
            else
            {
                Console.WriteLine("Calories: ");
                string cupCal = Console.ReadLine();

                Console.WriteLine("Flavour: ");
                string cupFlav = Console.ReadLine();

                Console.WriteLine("Ingrediants: ");
                string cupIngr = Console.ReadLine();
                Cupcake cup = new Cupcake(cupCal, cupFlav, cupIngr);

                File.WriteAllText(pathName, string.Join("; ", (customer.FirstName, customer.LastName, cup.Calory, cup.Flavour, cup.Ingrediants)));
            }


            // Console.WriteLine(string.Join("; ", (customer.FirstName, customer.LastName, cake.Calory, cake.Flavour, cup.Calory, cup.Flavour, cup.Ingrediants)));
            // File.WriteAllText(pathName, string.Join("; ", (customer.FirstName, customer.LastName, cake.Calory, cake.Flavour, cup.Calory, cup.Flavour, cup.Ingrediants))); // WriteAllText() 

            Console.ReadKey();
        }
    }
}
