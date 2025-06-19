using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Application entry point and startup coordinator
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry method for application execution
        /// </summary>
        public static void Main()
        {
            try
            {
                IDataLoader dataLoader = new FileDataLoader();

                List<Product> products = dataLoader.LoadProducts();
                List<Warehouse> warehouseItems = dataLoader.LoadWarehouse(products);

                WarehouseManager manager = new WarehouseManager(products, warehouseItems);
                manager.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.DataLoadingError + ex.Message);
            }
        }
    }
}
