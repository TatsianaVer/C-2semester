using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// File-based implementation of IDataLoader
    /// </summary>
    public class FileDataLoader : IDataLoader
    {
        /// <summary>
        /// Loads products from products.txt
        /// </summary>
        /// <returns>List of Products (empty if missing/invalid)</returns>
        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            if (File.Exists(Constants.ProductsFilePath))
            {
                foreach (string line in File.ReadLines(Constants.ProductsFilePath))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        products.Add(new Product(
                            parts[0].Trim(),
                            decimal.Parse(parts[1].Trim()),
                            int.Parse(parts[2].Trim())
                            ));
                    }
                }
            }

            return products;
        }

        /// <summary>
        /// Loads warehouse data from warehouse.txt
        /// </summary>
        /// <param name="products">Preloaded list for product association</param>
        /// <returns>List of warehouse items</returns>
        public List<Warehouse> LoadWarehouse(List<Product> products)
        {
            List<Warehouse> warehouseItems = new List<Warehouse>();

            if (File.Exists(Constants.WarehouseFilePath))
            {
                foreach (string line in File.ReadLines(Constants.WarehouseFilePath))
                {
                    string[] parts = line.Split(";");
                    if ( parts.Length == 4)
                    {
                        string productName = parts[0].Trim();
                        Product product = products.FirstOrDefault(p => p.Name == productName);

                        if (product != null)
                        {
                            warehouseItems.Add(new Warehouse(
                                product,
                                parts[1].Trim(),
                                decimal.Parse(parts[2].Trim()),
                                int.Parse(parts[3].Trim())
                                ));
                        }
                    }
                }
            }

            return warehouseItems;
        }
    }
}
