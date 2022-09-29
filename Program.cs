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
            Console.WriteLine();

            List<Product> products = new List<Product>();
            products.Add(new Product("Ramen Noodles", "Food", "5$", false));
            products.Add(new Product("Television", "Electronics", "400$", false));
            products.Add(new Product("Mexican Chips", "Food", "15$", true));
            products.Add(new Product("The Pragmatic Programmer", "Book", "25$", true));
            products.Add(new Product("Stethoscope", "Medical", "100$", false));
            products.Add(new Product("Playstation 5", "Merchandise", "1,000$", true));

            bool shoppingInProgress = true;
            string response = "";
            ShoppingCart shoppingCart = new ShoppingCart();

            while(shoppingInProgress)
            {
                DisplayProducts(products);
                Console.WriteLine();
                Console.Write("Select item to purchase: ");
                response = Console.ReadLine().ToLower();
                Product productSelected = products[Int32.Parse(response) - 1];
                Item selectedItem = new Item(productSelected.Name, productSelected.Price, productSelected.Import, productSelected.Type);
                shoppingCart.AddItemToShoppingCart(selectedItem);
                Console.WriteLine($"{productSelected.Name} was added to cart!");
                Console.WriteLine();
                Console.Write("Ready to checkout? (Y/N): ");
                response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    shoppingInProgress = false;
                }
            }

            List<Item> cart = shoppingCart.GetItemsFromShoppingCart();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Number of Items in Cart: {cart.Count}");
            DisplayShoppingCart(cart);
    
        }

        public static void DisplayProducts(List<Product> products)
        {
            int i = 1;
            foreach (var item in products)
            {
                Console.WriteLine($"{i}) Name: {item.Name} || Price: {item.Price}");
                i++;
            }
        }

        public static void DisplayShoppingCart(List<Item> shoppingCart)
        {
            Console.WriteLine("Items in Cart:");
            int i = 1;
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"{i}) Name: {item.ItemName} || Price: {item.ItemRetailPrice}");
                i++;
            }
        }
    }
}
