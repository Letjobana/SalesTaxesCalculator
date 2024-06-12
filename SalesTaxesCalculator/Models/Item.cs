namespace SalesTaxesCalculator.Models
{
    public class Item
    {
        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the price of the item before taxes.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Indicates whether the item is imported.
        /// </summary>
        public bool IsImported { get; }

        /// <summary>
        /// Indicates whether the item is exempt from basic sales tax.
        /// </summary>
        public bool IsExempt { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="price">The price of the item before taxes.</param>
        /// <param name="isImported">Indicates whether the item is imported.</param>
        /// <param name="isExempt">Indicates whether the item is exempt from basic sales tax.</param>
        public Item(string name, decimal price, bool isImported, bool isExempt)
        {
            Name = name;
            Price = price;
            IsImported = isImported;
            IsExempt = isExempt;
        }
    }
}