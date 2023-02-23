using System;
using System.Collections.Generic;
using SOLID.Classes;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Money class
            Money money = new Money(10, 50);
            money.DisplayAmount(); // Output: 10.50
            money.SetWholePart(20);
            money.SetPennies(75);
            money.DisplayAmount(); // Output: 20.75

            // Testing Product class
            Product product = new Product("Apple", 1.25m, "Fruit");
            Console.WriteLine($"Product Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
            product.ReducePrice(0.25m);
            Console.WriteLine($"New Price: {product.Price}");

            // Testing Warehouse class
            Warehouse warehouse = new Warehouse("Apples", "kg", 1.50m, 100, new DateTime(2021, 01, 01));
            Console.WriteLine($"Product Name: {warehouse.Name}, Quantity: {warehouse.Quantity}, Price Per Unit: {warehouse.PricePerUnit}");
            warehouse.ReceiveGoods(50, 2.00m, new DateTime(2021, 06, 01));
            Console.WriteLine($"Updated Quantity: {warehouse.Quantity}, Updated Price Per Unit: {warehouse.PricePerUnit}, Date of Last Delivery: {warehouse.DateOfLastDelivery}");
            warehouse.ShipGoods(25);
            Console.WriteLine($"Updated Quantity: {warehouse.Quantity}");

            // Testing Reporting class
            Reporting reporting = new Reporting();
            reporting.GenerateReceiptInvoice(warehouse);
            reporting.GenerateExpenseInvoice(warehouse, 10);

            List<Warehouse> warehouses = new List<Warehouse>()
            {
                new Warehouse("Apples", "kg", 1.50m, 100, new DateTime(2021, 01, 01)),
                new Warehouse("Oranges", "kg", 2.00m, 75, new DateTime(2021, 02, 01)),
                new Warehouse("Bananas", "kg", 1.25m, 50, new DateTime(2021, 03, 01))
            };
            reporting.GenerateInventoryReport(warehouses);
        }
    }
}
