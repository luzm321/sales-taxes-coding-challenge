using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesConsoleApp
{
    public class Item
    {
        public string ItemName;
        public bool IsImport;
        public string Type;
        public string ItemRetailPrice;
        //private string _accruedOverallTax;
        //private string _addedTax;
        //private string _importTax;
        //private string _salesTax;
        //private string _accruedImportTax;
        //private string _accruedSalesTax;
        //private string _totalPrice;
        //private string _totalPriceAfterTax;
        //private int _quantity;


        //public Item(string itemName, string itemRetailPrice, string accruedOverallTax,
        //    string addedTax, string importTax, string salesTax, string accruedImportTax,
        //    string accruedSalesTax, string totalPrice, string totalPriceAfterTax, bool isImport,
        //    string type, int quantity)

        public Item(string itemName, string itemRetailPrice, bool isImport, string type)
        {
            ItemName = itemName;
            IsImport = isImport;
            Type = type;
            ItemRetailPrice = itemRetailPrice;
            //_accruedOverallTax = accruedOverallTax;
            //_addedTax = addedTax;
            //_importTax = importTax;
            //_salesTax = salesTax;
            //_accruedImportTax = accruedImportTax;
            //_accruedSalesTax = accruedSalesTax;
            //_totalPrice = totalPrice;
            //_totalPriceAfterTax = totalPriceAfterTax;         
            //_quantity = quantity;
        }
    }
}
