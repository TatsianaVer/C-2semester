using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    /// <summary>
    /// Centralized storage for all application constants
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// File and data processing constants
        /// </summary>
        public const string InputFile = "C:/Users/tatan/Documents/GitHub/C-2semester/Warehouse(7)/warehouse/products.txt";
        public const string OutputFilePrefix = "Supplier_";
        public const string OutputFileExtension = ".txt";
        public const char DataSeparator = ';';
        public const int ExpectedFieldCount = 4;
        public const string FileName = "C:/Users/tatan/Documents/GitHub/C-2semester/Warehouse(7)/warehouse/WrittenFile.txt";

        /// <summary>
        /// Report formatting constants
        /// </summary>
        public const string ReportHeader = "| #    | Product Name    | Stock Quantity | Total Value  |\n|---|---|---|---|";
        public const string ReportRowFormat = "| {0} | {1} | {2} | {3:C} |";
        public const string DateTimeFormat = "yyyy-MM-dd_HHmmss";
        public const string ExportFileNameFormat = "Export_{0}_{1}.txt";

        /// <summary>
        /// Product information constants
        /// </summary>
        public const string ProductInfoFormat = "{0}; Supplier: {1}; Price: {2:C}; Quantity: {3}; Total value: {4:C}";
        public const string UnknownProduct = "Unknown product";

        /// <summary>
        /// User interface messages
        /// </summary>
        public const string DataFileNotFound = "Error: Data file not found";
        public const string AvailableProductsHeader = "Available products:";
        public const string EnterProductCodePrompt = "\nEnter product code: ";
        public const string InvalidInputMessage = "Invalid input";
        public const string MatchingProductsHeader = "\nMatching products:";
        public const string NoProductsFoundMessage = "No products found with specified code";
        public const string ExportPrompt = "\nPress End key to export results...";
        public const string ExportConfirmation = "\nExported {0} records to {1}";
        public const string ReportsGeneratedMessage = "\nSupplier reports generated successfully";
        public const string PressAnyKeyMessage = "\nPress any key to exit...";
    }
}
