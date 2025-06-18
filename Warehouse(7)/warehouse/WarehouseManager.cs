using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    /// <summary>
    /// Manages warehouse operations including data loading and reporting
    /// </summary>
    public class WarehouseManager
    {
        private readonly List<ProductRecord> _products = new List<ProductRecord>();

        /// <summary>
        /// Collection of all product records loaded from file
        /// </summary>
        public List<ProductRecord> Products
        {
            get { return _products; }
        }

        /// <summary>
        /// Loads product data from the input file
        /// </summary>
        public void LoadData()
        {
            // Check if input file exists
            if (!File.Exists(Constants.InputFile))
            {
                Console.WriteLine(Constants.DataFileNotFound);
                return;
            }

            // Process each line in the input file
            foreach (string line in File.ReadAllLines(Constants.InputFile))
            {
                // Split line into components using defined separator
                string[] parts = line.Split(Constants.DataSeparator);

                // Skip invalid lines
                if (parts.Length != Constants.ExpectedFieldCount) continue;

                // Parse and validate data fields
                int code;
                decimal price;
                int quantity;

                if (int.TryParse(parts[0].Trim(), out code) &&
                    decimal.TryParse(parts[2].Trim(), out price) &&
                    int.TryParse(parts[3].Trim(), out quantity))
                {
                    // Add valid record to collection
                    _products.Add(new ProductRecord(
                        code,
                        parts[1].Trim(),
                        price,
                        quantity
                    ));
                }
            }
        }

        /// <summary>
        /// Retrieves products matching a specific product code
        /// </summary>
        /// <param name="code">Product code to search for</param>
        /// <returns>List of matching product records</returns>
        public List<ProductRecord> GetProductsByCode(int code)
        {
            List<ProductRecord> result = new List<ProductRecord>();
            foreach (ProductRecord product in _products)
            {
                if (product.Code == code)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        /// <summary>
        /// Generates supplier-specific reports sorted by product value
        /// </summary>
        public void GenerateSupplierReports()
        {
            // Group products by supplier
            Dictionary<string, List<ProductRecord>> supplierGroups = new Dictionary<string, List<ProductRecord>>();
            foreach (ProductRecord product in _products)
            {
                if (!supplierGroups.ContainsKey(product.Supplier))
                {
                    supplierGroups[product.Supplier] = new List<ProductRecord>();
                }
                supplierGroups[product.Supplier].Add(product);
            }

            // Process each supplier group
            foreach (KeyValuePair<string, List<ProductRecord>> group in supplierGroups)
            {
                // Sort products by total value
                List<ProductRecord> sortedProducts = group.Value;
                for (int i = 0; i < sortedProducts.Count - 1; i++)
                {
                    for (int j = i + 1; j < sortedProducts.Count; j++)
                    {
                        if (sortedProducts[i].TotalValue > sortedProducts[j].TotalValue)
                        {
                            ProductRecord temp = sortedProducts[i];
                            sortedProducts[i] = sortedProducts[j];
                            sortedProducts[j] = temp;
                        }
                    }
                }

                // Generate filename using supplier name
                string fileName = string.Format(
                    "{0}{1}{2}",
                    Constants.OutputFilePrefix,
                    group.Key.Replace(" ", "_"),
                    Constants.OutputFileExtension
                );

                // Write report to file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Write supplier header
                    writer.WriteLine(group.Key);
                    writer.WriteLine(Constants.ReportHeader);

                    // Write product details
                    for (int i = 0; i < sortedProducts.Count; i++)
                    {
                        ProductRecord product = sortedProducts[i];
                        writer.WriteLine(
                            Constants.ReportRowFormat,
                            i + 1,
                            product.GetProductName(),
                            product.Quantity,
                            product.TotalValue
                        );
                    }
                }
            }
        }
    }
}
