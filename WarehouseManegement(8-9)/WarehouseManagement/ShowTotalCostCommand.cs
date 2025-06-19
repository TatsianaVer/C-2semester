using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Command to calculate and display total inventory value
    /// </summary>
    public class ShowTotalCostCommand : IMenuCommand
    {
        private readonly List<Warehouse> _warehouseItems;

        /// <summary>
        /// Constructs command with warehouse inventory data
        /// </summary>
        /// <param name="warehouseItems">Current warehouse inventory collection</param>
        public ShowTotalCostCommand(List<Warehouse> warehouseItems)
        {
            _warehouseItems = warehouseItems;
        }

        /// <summary>
        /// Executes total cost calculation and display
        /// </summary>
        public void Execute()
        {
            decimal total = _warehouseItems.Sum(w => w.TotalCost);
            Console.WriteLine(Constants.TotalCostMessage, total);
        }
    }
}
