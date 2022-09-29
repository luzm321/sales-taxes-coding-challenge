using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SalesTaxesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, welcome to The Store!");
            Console.WriteLine();

            Console.WriteLine("Choose item to purchase by number:");

            List<Product> products = new List<Product>();
            products.Add(new Product("Ramen Noodles", "Food", "5$", false));
            products.Add(new Product("Television", "Electronics", "400$", false));
            products.Add(new Product("Mexican Chips", "Food", "15$", true));
            products.Add(new Product("The Pragmatic Programmer", "Book", "25$", true));
            products.Add(new Product("Stethoscope", "Medical", "100$", false));
            products.Add(new Product("Playstation 5", "Merchandise", "1,000$", true));

            int i = 1;
            foreach (var item in products)
            {
                Console.WriteLine($"{i}) Name: {item.Name} || Price: {item.Price}");
                i++;
            }

            Console.WriteLine();
            Console.Write("Select item: ");
            string response = Console.ReadLine().ToLower();
            Console.WriteLine(products[Int32.Parse(response) - 1].Name);

        }
    }
}
