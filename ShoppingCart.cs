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
            bool containsItem = shoppingCartItems.Any(cartItem => cartItem.ItemName == item.ItemName);
            if (containsItem)
            {
                int index = 0;
                foreach (var cartItem in shoppingCartItems)
                {
                    if (cartItem.ItemName == item.ItemName)
                    {
                        index = shoppingCartItems.IndexOf(cartItem);
                    }
                }
                shoppingCartItems.RemoveAt(index);
                UpdateItemFromShoppingCart(item);
            }
            else
            {
                shoppingCartItems.Add(item);
            }
        }

        public void UpdateItemFromShoppingCart(Item item)
        {
            int newItemQuantity = item.Quantity + 1;
            string newTotalPrice = item.TotalPrice + new CurrencyToNumberConverter().ConvertFromCurrency(item.ItemRetailPrice);
            Double newPriceAfterTax = (item.TotalPriceAfterTax + item.TotalPriceAfterTax);
            Double accruedImportTax = (item.AccruedImportTax + item.ImportTax);
            Double accruedSalesTax = (item.AccruedSalesTax + item.SalesTax);
            Double accruedOverallTax = (item.AccruedOverallTax + item.AddedTax);
            Item updatedItem = new Item
            (
                item.ItemName, item.ItemRetailPrice, item.IsImport, item.Type, item.ImportTax, item.SalesTax, item.AddedTax, newPriceAfterTax, 
                accruedImportTax, accruedSalesTax, accruedOverallTax, newTotalPrice, newItemQuantity
            );
            shoppingCartItems.Add(updatedItem);
        }

        public List<Item> GetItemsFromShoppingCart()
        {
            return shoppingCartItems;
        }
    }
}