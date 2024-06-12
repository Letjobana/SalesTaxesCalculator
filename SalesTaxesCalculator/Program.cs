using SalesTaxesCalculator.Models;
using SalesTaxesCalculator.Receipts;
using SalesTaxesCalculator.Services;
using System;

namespace SalesTaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = {
                "1 book at 12.49",
                "1 music CD at 14.99",
                "1 chocolate bar at 0.85"
            };

            string[] input2 = {
                "1 imported box of chocolates at 10.00",
                "1 imported bottle of perfume at 47.50"
            };

            string[] input3 = {
                "1 imported bottle of perfume at 27.99",
                "1 bottle of perfume at 18.99",
                "1 packet of paracetamol at 9.75",
                "1 imported box of chocolates at 11.25"
            };

            PrintReceipts(new[] { input1, input2, input3 });
        }

        static void PrintReceipts(string[][] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                var items = InputParser.ParseInput(inputs[i]);
                var receipt = new SalesTaxesCalculator.Receipts.Receipt();
                foreach (var item in items)
                {
                    receipt.AddItem(item);
                }
                Console.WriteLine($"Output {i + 1}:");
                receipt.PrintReceipt();
                Console.WriteLine();
            }
        }
    }
}
