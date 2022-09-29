using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesConsoleApp
{
    public class Item
    {
        private string _itemName;
        private string _itemRetailPrice;
        private string _accruedOverallTax;
        private string _addedTax;
        private string _importTax;
        private string _salesTax;
        private string _accruedImportTax;
        private string _accruedSalesTax;
        private string _totalPrice;
        private string _totalPriceAfterTax;
        private bool _isImport;
        private string _type;
        private int _quantity;

        public Item(string itemName, string itemRetailPrice, string accruedOverallTax,
            string addedTax, string importTax, string salesTax, string accruedImportTax,
            string accruedSalesTax, string totalPrice, string totalPriceAfterTax, bool isImport,
            string type, int quantity)
        {
            _itemName = itemName;
            _itemRetailPrice = itemRetailPrice;
            _accruedOverallTax = accruedOverallTax;
            _addedTax = addedTax;
            _importTax = importTax;
            _salesTax = salesTax;
            _accruedImportTax = accruedImportTax;
            _accruedSalesTax = accruedSalesTax;
            _totalPrice = totalPrice;
            _totalPriceAfterTax = totalPriceAfterTax;
            _isImport = isImport;
            _type = type;
            _quantity = quantity;
        }
    }
}
