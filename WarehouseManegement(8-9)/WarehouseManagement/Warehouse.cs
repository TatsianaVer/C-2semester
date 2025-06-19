using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    /// <summary>
    /// Represents a warehouse inventory item implementing product observer
    /// </summary>
    public class Warehouse : IProductObserver
    {
        private Product _product;
        private decimal _markupPercent;

        /// <summary>
        /// Supplier name (immutable after construction)
        /// </summary>
        public string Supplier { get; }

        /// <summary>
        /// Stock quantity (immutable after construction)
        /// </summary>
        public int Quantity { get; }

        /// <summary>
        /// Associated product reference
        /// </summary>
        public Product Product
        {
            get
            {
                return _product;
            }
        }

        /// <summary>
        /// Calculated release price (unit price + markup)
        /// </summary>
        public decimal ReleasePrice
        {
            get
            {
                return _product.Price * (1 + _markupPercent / 100);
            }
        }

        /// <summary>
        /// Total inventory value
        /// </summary>
        public decimal TotalCost
        {
            get
            {
                return ReleasePrice * Quantity;
            }
        }

        /// <summary>
        /// Constructs warehouse item with product association
        /// </summary>
        /// <param name="product">Product reference</param>
        /// <param name="supplier">Supplier name</param>
        /// <param name="markupPercent">Initial markup percentage</param>
        /// <param name="quantity">Stock quantity</param>
        public Warehouse(Product product, string supplier, decimal markupPercent, int quantity)
        {
            _product = product;
            Supplier = supplier;
            _markupPercent = markupPercent;
            Quantity = quantity;

            _product.NameChanged += HandleNameChanged;
            _product.ExpirationPeriodChanged += HandleExpirationChanged;
        }

        /// <summary>
        /// Handles product renaming events
        /// </summary>
        /// <param name="sender">Product instance</param>
        /// <param name="oldName">Original product name</param>
        /// <param name="newName">Updated product name</param>
        public void HandleNameChanged(Product sender, string oldName, string newName)
        {
            Console.WriteLine(Constants.ProductRenamed, oldName, newName);
        }

        /// <summary>
        /// Handles expiration period changes
        /// </summary>
        /// <param name="sender">Product instance</param>
        public void HandleExpirationChanged(Product sender)
        {
            if (Quantity > Constants.StockThreshold)
            {
                _markupPercent -= Constants.MarkupReductionPercent;
                Console.WriteLine(Constants.MarkupReduced, _product.Name, _markupPercent);
            }
        }

        /// <summary>
        /// Displays inventory information in table format
        /// </summary>
        /// <param name="index">Display sequence number</param>
        public void DisplayInfo(int index)
        {
            Console.WriteLine(
                Constants.ProductRowFormat,
                index,
                _product.Name,
                ReleasePrice,
                Quantity,
                TotalCost
                );
        }
    }
}
