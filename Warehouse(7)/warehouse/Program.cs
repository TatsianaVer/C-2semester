using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    /// <summary>
    /// Main program entry point
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry method
        /// </summary>
        static void Main()
        {
            // Initialize warehouse manager
            WarehouseManager manager = new WarehouseManager();
            manager.LoadData();

            // Display product menu
            Console.WriteLine(Constants.AvailableProductsHeader);
            foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
            {
                Console.WriteLine("{0}: {1}", (int)code, code);
            }

            // Get user selection
            Console.Write(Constants.EnterProductCodePrompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int selectedCode))
            {
                // Retrieve matching products
                List<ProductRecord> products = manager.GetProductsByCode(selectedCode);

                // Display results
                if (products.Count > 0)
                {
                    Console.WriteLine(Constants.MatchingProductsHeader);
                    foreach (ProductRecord product in products)
                    {
                        Console.WriteLine(product.FormatProductInfo());
                    }

                    // Check for export request
                    Console.WriteLine(Constants.ExportPrompt);
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.End)
                    {
                        ExportResults(products, selectedCode);
                    }
                }
                else
                {
                    Console.WriteLine(Constants.NoProductsFoundMessage);
                }
            }
            else
            {
                Console.WriteLine(Constants.InvalidInputMessage);
            }

            // Generate all supplier reports
            manager.GenerateSupplierReports();
            Console.WriteLine(Constants.ReportsGeneratedMessage);

            // Keep console open
            Console.WriteLine(Constants.PressAnyKeyMessage);
            Console.ReadKey();
        }

        /// <summary>
        /// Exports search results to timestamped text file
        /// </summary>
        /// <param name="products">Products to export</param>
        /// <param name="productCode">Product code used in search</param>
        private static void ExportResults(List<ProductRecord> products, int productCode)
        {
            // Generate filename with timestamp
            string fileName = string.Format(
                Constants.ExportFileNameFormat,
                productCode,
                DateTime.Now.ToString(Constants.DateTimeFormat)
            );

            // Write products to file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (ProductRecord product in products)
                {
                    writer.WriteLine(product.FormatProductInfo());
                }
            }

            Console.WriteLine(
                Constants.ExportConfirmation,
                products.Count,
                fileName
            );
        }
    }
}
