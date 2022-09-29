using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesConsoleApp
{
    public class ShoppingCart : List<Item>
    {
        List<Item> shoppingCartItems = new List<Item>();
        
        public void AddItemToShoppingCart(Item item)
        {
            shoppingCartItems.Add(item);
        }

        public List<Item> GetItemsFromShoppingCart()
        {
            return shoppingCartItems;
        }
    }
}
