using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Represents a product entity with observable properties
    /// </summary>
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _expirationPeriod;

        /// <summary>
        /// Event for product name changes
        /// </summary>
        public event Action<Product, string, string> NameChanged;

        /// <summary>
        /// Event for expiration period changes
        /// </summary>
        public event Action<Product> ExpirationPeriodChanged;

        /// <summary>
        /// Product name with change notification
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    string oldName = _name;
                    _name = value;
                    NameChanged?.Invoke(this, oldName, _name);
                }
            }
        }

        /// <summary>
        /// Product price (no change tracking)
        /// </summary>
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Expiration period in days with change notification
        /// </summary>
        public int ExpirationPeriod
        {
            get
            {
                return _expirationPeriod;
            }
            set
            {
                if (_expirationPeriod != value)
                {
                    _expirationPeriod = value;
                    ExpirationPeriodChanged?.Invoke(this);
                }
            }
        }

        /// <summary>
        /// Constructs a new product instance
        /// </summary>
        /// <param name="name">Initial product name</param>
        /// <param name="price">Initial price</param>
        /// <param name="expirationPeriod">Initial expiration in days</param>
        public Product(string name, decimal price, int expirationPeriod)
        {
            _name = name;
            _price = price;
            _expirationPeriod = expirationPeriod;
        }
    }
}
