using SalesTaxesCalculator.Models;
using System.Globalization;

namespace SalesTaxesCalculator.Services
{
    public class InputParser
    {
        public static List<Item> ParseInput(string[] inputs)
        {
            var items = new List<Item>();

            foreach (var input in inputs)
            {
                // Example input: "1 Book at 12.49"
                var parts = input.Split(new[] { " at " }, StringSplitOptions.None);
                var price = decimal.Parse(parts[1], CultureInfo.InvariantCulture);
                var namePart = parts[0].Split(' ', 2);
                var name = namePart[1];
                var isImported = name.Contains("imported");
                var isExempt = name.Contains("book") || name.Contains("chocolate") || name.Contains("pill");

                items.Add(new Item(name, price, isImported, isExempt));
            }

            return items;
        }
    }
}
