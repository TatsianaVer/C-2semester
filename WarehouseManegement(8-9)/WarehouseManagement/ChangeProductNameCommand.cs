using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Command to change product names
    /// </summary>
    public class ChangeProductNameCommand : IMenuCommand
    {
        private readonly List<Product> _products;

        /// <summary>
        /// Constructs command with product list
        /// </summary>
        /// <param name="products">Current product collection</param>
        public ChangeProductNameCommand(List<Product> products)
        {
            _products = products;
        }

        /// <summary>
        /// Executes product renaming workflow
        /// </summary>
        public void Execute()
        {
            
            Console.WriteLine(Constants.EnterCurrentProductName);
            string oldName = Console.ReadLine();

            Product product = _products.FirstOrDefault(p =>
            p.Name.Equals(oldName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine(Constants.ProductNotFound);
                return;
            }
            
            Console.WriteLine(Constants.EnterNewName);
            product.Name = Console.ReadLine();
        }
    }
}
