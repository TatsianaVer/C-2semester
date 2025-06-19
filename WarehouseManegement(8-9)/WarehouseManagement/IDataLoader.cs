using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Data loading service contract
    /// </summary>
    public interface IDataLoader
    {
        /// <summary>
        ///  Loads product data from persistent storage
        /// </summary>
        /// <returns>List of initialized Product objects</returns>
        List<Product> LoadProducts();
        List<Warehouse> LoadWarehouse(List<Product> products);
    }
}
