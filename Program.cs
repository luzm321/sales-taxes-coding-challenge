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
            products.Add(new Product("Mexican Chips", "Food", "15$", true));

            int i = 1;
            foreach (var item in products)
            {
                Console.WriteLine($"{i}) Name: {item.Name} || Price: {item.Price}");
                i++;
            }

            Console.WriteLine();
            Console.Write("Select item: ");
            string repeatQuest = Console.ReadLine().ToLower();
            Console.WriteLine(products[Int32.Parse(repeatQuest) - 1].Name);

        }
    }
}
