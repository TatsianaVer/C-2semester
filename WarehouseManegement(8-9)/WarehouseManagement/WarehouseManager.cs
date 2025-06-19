using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Central application controller managing menu execution
    /// </summary>
    public class WarehouseManager
    {
        private readonly List<Warehouse> _warehouseItems;
        private readonly Dictionary<string, IMenuCommand> _commands;

        /// <summary>
        /// Constructs manager with business data
        /// </summary>
        /// <param name="products">Product master list</param>
        /// <param name="warehouseItems">Current inventory data</param>
        public WarehouseManager(List<Product> products, List<Warehouse> warehouseItems)
        {
            _warehouseItems = warehouseItems;

            _commands = new Dictionary<string, IMenuCommand>
            {
                { "1", new ShowSupplierProductsCommand(warehouseItems) },
                { "2", new ChangeProductNameCommand(products) },
                { "3", new ShowTotalCostCommand(warehouseItems) },
                { "4", new FindExpensiveProductsCommand(warehouseItems) },
                { "5", new ExitCommand() }
            };
        }

        /// <summary>
        /// Main application execution loop
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine(Constants.MenuSeparator);
                Console.WriteLine(Constants.MenuOptions);
                Console.WriteLine(Constants.MenuSeparator);

                string choice = Console.ReadLine();
                if (_commands.TryGetValue(choice, out IMenuCommand command))
                {
                    command.Execute();
                }
                else
                {
                    Console.WriteLine(Constants.InvalidInput);
                }
            }
        }
    }
}
