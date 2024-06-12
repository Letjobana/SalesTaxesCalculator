using SalesTaxesCalculator.Models;
using SalesTaxesCalculator.Services;

namespace SalesTaxesCalculator.Receipts
{
    public class Receipt
    {
        private List<Item> _items;

        public Receipt()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void PrintReceipt()
        {
            decimal totalTax = 0m;
            decimal totalPrice = 0m;

            foreach (var item in _items)
            {
                decimal itemTax = TaxCalculator.CalculateTax(item);
                decimal itemTotalPrice = item.Price + itemTax;
                totalTax += itemTax;
                totalPrice += itemTotalPrice;

                Console.WriteLine($"{item.Name}: {itemTotalPrice:F2}");
            }

            Console.WriteLine($"Sales Taxes: {totalTax:F2}");
            Console.WriteLine($"Total: {totalPrice:F2}");
        }
    }
}
