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
        static void cupCakeFunction(string pathName, int quantity) // we declare the datatype only while declaring e.g. a function
        {
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Cupcake №"+ i + "\n" + "Calories: ");
                string cupCal = Console.ReadLine();

                Console.WriteLine("Flavour: ");
                string cupFlav = Console.ReadLine();

                Console.WriteLine("Ingrediants: ");
                string cupIngr = Console.ReadLine();
                Cupcake cup = new Cupcake(cupCal, cupFlav, cupIngr);

                File.AppendAllText(pathName, string.Join("; ", ("Cupcake", cup.Calory, cup.Flavour, cup.Ingrediants)));
            }
            
        }
        static void cakeFunction(string pathName, int quantity)
        {
            for (int i = 1; i <= quantity; i++)
            {
                // TASK 1: initialize Calories as int
                Console.WriteLine("Cake №" + i + "\n" + "Calories: ");
                string cakeCal = Console.ReadLine(); // int cakeCal = int.Parse(Console.ReadLine()); 

                Console.WriteLine("Flavour: ");
                string cakeFlav = Console.ReadLine();
                Cake cake = new Cake(cakeCal, cakeFlav); // obj cake is created

                File.AppendAllText(pathName, string.Join("; ", ("Cake", cake.Calory, cake.Flavour)));
            }

        }
        static void Main(string[] args)
        {
            string pathName = "C:\\Users\\Sulpak\\source\\repos\\ConsoleApp1\\ConsoleAppProject\\myBill.txt";

            Console.WriteLine("Name: ");
            string custName = Console.ReadLine();

            Console.WriteLine("Last name: ");
            string custLast = Console.ReadLine();
            Customer customer = new Customer(custName, custLast);

            File.WriteAllText(pathName, string.Join("; ", (customer.FirstName, customer.LastName))); // TASK 2: designate 


            while (true)
            {
                Console.WriteLine("What do u prefer? Cake - 1; Cupcake - 2; Thats it - 3 ");
                int sweet = int.Parse(Console.ReadLine());
                if (sweet != 3) {
                    Console.WriteLine("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    switch (sweet)
                    {
                        case 1:
                            cakeFunction(pathName, quantity);
                            break;
                        default:
                            cupCakeFunction(pathName, quantity);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Check myBill");
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
