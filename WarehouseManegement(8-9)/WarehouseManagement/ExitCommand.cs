using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Alternative exit command
    /// </summary>
    public class ExitCommand : IMenuCommand
    {
        /// <summary>
        /// Executes application shutdown
        /// </summary>
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
