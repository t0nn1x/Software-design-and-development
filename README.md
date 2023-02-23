# SOLID Principles Project

This project aims to demonstrate the SOLID principles by implementing different classes for managing money, products, warehouses, and reporting.

## Classes

- Money: a class for working with money. It has fields for storing the whole part and pennies of the amount, and methods for displaying and setting the values.
- Product: a class for working with products or commodities. It has a method for reducing the price.
- Warehouse: a class for managing goods stored in a warehouse. It has fields for the name, unit of measurement, price per unit, quantity, date of last delivery, etc. It also has methods for receiving and shipping goods.
- Reporting: a class for working with reporting. It has methods for generating receipt and expense invoices, as well as an inventory report.

## Usage

To use the classes, simply create instances and call their methods. For example:

```csharp
Money money = new Money(10, 50);
money.DisplayAmount(); // Output: 10.50
money.SetWholePart(20);
money.SetPennies(75);
money.DisplayAmount(); // Output: 20.75

Product product = new Product("Apple", 1.25m, "Fruit");
product.ReducePrice(0.25m);
Console.WriteLine($"New Price: {product.Price}");

Warehouse warehouse = new Warehouse("Apples", "kg", 1.50m, 100, new DateTime(2021, 01, 01));
warehouse.ReceiveGoods(50, 2.00m, new DateTime(2021, 06, 01));
Console.WriteLine($"Updated Quantity: {warehouse.Quantity}, Updated Price Per Unit: {warehouse.PricePerUnit}, Date of Last Delivery: {warehouse.DateOfLastDelivery}");

warehouse.ShipGoods(25);
Console.WriteLine($"Updated Quantity: {warehouse.Quantity}");

Reporting reporting = new Reporting();
reporting.GenerateReceiptInvoice(warehouse);
reporting.GenerateExpenseInvoice(warehouse, 10);
reporting.GenerateInventoryReport(new List<Warehouse> { warehouse });
```

## Additional Functionality

In addition to the classes required by the project, I have added a few features to illustrate the SOLID principles:

- Category: each product can belong to a category, which allows for better organization and filtering.
- Child Currency Classes: for different currencies, we can create child classes that inherit from the Money class and provide currency-specific functionality.
- Shopping Cart: a class for managing shopping carts and orders, which can be used in an e-commerce system.

## Conclusion

By following the SOLID principles, we can create classes that are easy to understand, maintain, and extend. This project demonstrates how these principles can be applied to real-world scenarios, such as managing money, products, warehouses, and reporting.
