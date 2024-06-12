using SalesTaxesCalculator.Models;

namespace SalesTaxesCalculator.Services
{
    public class TaxCalculator
    {
        public static decimal CalculateTax(Item item)
        {
            decimal tax = 0m;

            if (!item.IsExempt)
            {
                tax += item.Price * 0.10m;
            }

            if (item.IsImported)
            {
                tax += item.Price * 0.05m;
            }

            // Round up to the nearest 0.05
            tax = Math.Ceiling(tax * 20) / 20;

            return tax;
        }
    }
}
