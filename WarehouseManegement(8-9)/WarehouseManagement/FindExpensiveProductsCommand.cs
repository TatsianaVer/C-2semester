using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Command to find and display expensive products
    /// </summary>
    public class FindExpensiveProductsCommand : IMenuCommand
    {
        private readonly List<Warehouse> _warehouseItems;

        /// <summary>
        /// Constructs command with warehouse data
        /// </summary>
        /// <param name="warehouseItems">Current warehouse inventory</param>
        public FindExpensiveProductsCommand(List<Warehouse> warehouseItems)
        {
            _warehouseItems = warehouseItems;
        }

        /// <summary>
        /// Executes expensive products search
        /// </summary>
        public void Execute()
        {
            Console.WriteLine(Constants.EnterMinCost);
            string input = Console.ReadLine();

            if (!decimal.TryParse(input, out decimal minCost))
            {
                Console.WriteLine(Constants.InvalidInput);
                return;
            }

            List<Warehouse> items = _warehouseItems
                .Where(w => w.TotalCost > minCost)
                .ToList();

            if (items.Count == 0)
            {
                Console.WriteLine(Constants.NoProductsFound);
                return;
            }

            Console.WriteLine(Constants.ExpensiveProductsHeader);
            Console.WriteLine(Constants.ExpensiveTableDivider);

            foreach (Warehouse item in items)
            {
                Console.WriteLine(
                    Constants.SupplierHeaderFormat,
                    item.Supplier, 
                    item.Product.Name,
                    item.TotalCost
                    );
            }
        }
    }
}
