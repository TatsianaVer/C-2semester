using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Command pattern interface for menu operations
    /// </summary>
    public interface IMenuCommand
    {
        void Execute();
    }
}
