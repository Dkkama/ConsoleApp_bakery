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
        static void cupCakeFunction(string pathName) // we declare the datatype only while declaring e.g. a function
        {
            Console.WriteLine("Calories: ");
            string cupCal = Console.ReadLine();

            Console.WriteLine("Flavour: ");
            string cupFlav = Console.ReadLine();

            Console.WriteLine("Ingrediants: ");
            string cupIngr = Console.ReadLine();
            Cupcake cup = new Cupcake(cupCal, cupFlav, cupIngr);

            File.AppendAllText(pathName, string.Join("; ", ("Cupcake", cup.Calory, cup.Flavour, cup.Ingrediants))); 
        }
        static void cakeFunction(string pathName)
        {
            Console.WriteLine("Calories: ");
            string cakeCal = Console.ReadLine(); // int cakeCal = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Flavour: ");
            string cakeFlav = Console.ReadLine();
            Cake cake = new Cake(cakeCal, cakeFlav); // obj cake is created

            File.AppendAllText(pathName, string.Join("; ", ("Cake", cake.Calory, cake.Flavour)));
        }
        static void Main(string[] args)
        {
            string pathName = "C:\\Users\\Sulpak\\source\\repos\\ConsoleApp1\\ConsoleAppProject\\myFile.txt";

            Console.WriteLine("Name: ");
            string custName = Console.ReadLine();

            Console.WriteLine("Last name: ");
            string custLast = Console.ReadLine();
            Customer customer = new Customer(custName, custLast);

            File.WriteAllText(pathName, string.Join("; ", (customer.FirstName, customer.LastName))); // TO DO: designate 

            Console.WriteLine("What do u prefer? Cake - 1; Cupcake - 2 ");
            int sweet = int.Parse(Console.ReadLine());
            switch (sweet)
            {
                case 1: cakeFunction(pathName); 
                    break;
                default: cupCakeFunction(pathName);
                    break;
            }

            
            Console.ReadKey();
        }
    }
}
