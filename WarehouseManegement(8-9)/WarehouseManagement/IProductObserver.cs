using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement;

namespace WarehouseManagement
{
    /// <summary>
    ///  Observer contract for product changes
    /// </summary>
    public interface IProductObserver
    {
        /// <summary>
        /// Handles product name change events
        /// </summary>
        /// <param name="product">The modified product instance</param>
        /// <param name="oldName">Original product name</param>
        /// <param name="newName">Updated product name</param>
        void HandleNameChanged(Product product, string oldName, string newName);

        /// <summary>
        /// Handles product expiration period changes
        /// </summary>
        /// <param name="product">The modified product instance</param>
        void HandleExpirationChanged(Product product);
    }
}

