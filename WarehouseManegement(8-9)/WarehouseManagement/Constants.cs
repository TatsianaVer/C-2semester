using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Constants
    {
        public const decimal MarkupReductionPercent = 1.0m;
        public const int StockThreshold = 200;
        public const string ProductsFilePath = "Products.txt";
        public const string WarehouseFilePath = "Warehouse.txt";
        public const string MenuSeparator = "==========================================";
        public const string MenuOptions = "1. Show products by supplier\n2. Change product name\n3. Show total cost\n4. Find expensive products\n5. Exit";
        public const string DataLoadingError = "Data loading error: ";
        public const string InvalidInput = "Invalid input";
        public const string ProductNotFound = "Product not found";
        public const string NoProductsFound = "No products found";
        public const string EnterSupplierName = "Enter supplier name:";
        public const string EnterCurrentProductName = "Enter current product name:";
        public const string EnterNewName = "Enter new name:";
        public const string EnterMinCost = "Enter minimum cost:";
        public const string TotalCostMessage = "Total products cost: {0:N0}";
        public const string ProductRenamed = "Product renamed: {0} -> {1}";
        public const string MarkupReduced = "Markup reduced for {0} to {1}%";
        public const string SupplierProductsHeader = "| #  | Product Name          | Price      | Stock Quantity | Total Cost  |";
        public const string SupplierTableDivider = "|----|-----------------------|-----------|----------------|-------------|";
        public const string ExpensiveProductsHeader = "| Supplier          | Product Name          | Total Cost  |";
        public const string ExpensiveTableDivider = "|-------------------|-----------------------|-------------|";
        public const string SupplierHeaderFormat = "| {0,-18} | {1,-20} | {2,-12:N0} |";
        public const string ProductRowFormat = "| {0,-2} | {1,-20} | {2,-10:N0} | {3,-16} | {4,-12:N0} |";
    }
}
