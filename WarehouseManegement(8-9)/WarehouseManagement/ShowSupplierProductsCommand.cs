using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Command to display products by supplier
    /// </summary>
    public class ShowSupplierProductsCommand : IMenuCommand
    {
        private readonly List<Warehouse> _warehouseItems;

        /// <summary>
        /// Constructs command with warehouse inventory data
        /// </summary>
        /// <param name="warehouseItems">Current warehouse inventory collection</param>
        public ShowSupplierProductsCommand(List<Warehouse> warehouseItems)
        {
            _warehouseItems = warehouseItems;
        }

        /// <summary>
        /// Executes supplier product display workflow
        /// </summary>
        public void Execute()
        {
            Console.WriteLine(Constants.EnterSupplierName);
            string supplier = Console.ReadLine();

            List<Warehouse> items = _warehouseItems
                .Where(w => w.Supplier.Equals(supplier, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (items.Count == 0)
            {
                Console.WriteLine(Constants.NoProductsFound);
                return;
            }

            Console.WriteLine(supplier);
            Console.WriteLine(Constants.SupplierProductsHeader);
            Console.WriteLine(Constants.SupplierTableDivider);

            for (int i = 0; i < items.Count; i++)
            {
                items[i].DisplayInfo(i + 1);
            }
        }
    }
}
