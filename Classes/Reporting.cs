namespace SOLID.Classes
{
    public class Reporting
    {
        // Reporting class - responsible for handling reporting operations
        // Reporting class - depends on abstractions (interfaces) rather than concrete implementations of classes

        public void GenerateReceiptInvoice(Warehouse warehouse)
        {
            Console.WriteLine($"Receipt Invoice for {warehouse.Name}");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Product: {warehouse.Name}");
            Console.WriteLine($"Quantity: {warehouse.Quantity}");
            Console.WriteLine($"Price Per Unit: {warehouse.PricePerUnit}");
            Console.WriteLine($"Total Price: {warehouse.PricePerUnit * warehouse.Quantity}");
        }

        public void GenerateExpenseInvoice(Warehouse warehouse, int quantity)
        {
            Console.WriteLine($"Expense Invoice for {warehouse.Name}");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Product: {warehouse.Name}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price Per Unit: {warehouse.PricePerUnit}");
            Console.WriteLine($"Total Price: {warehouse.PricePerUnit * quantity}");
        }

        public void GenerateInventoryReport(List<Warehouse> warehouses)
        {
            Console.WriteLine("Inventory Report");
            Console.WriteLine($"Date: {DateTime.Now}");

            foreach (var warehouse in warehouses)
            {
                Console.WriteLine($"Product: {warehouse.Name}");
                Console.WriteLine($"Quantity: {warehouse.Quantity}");
                Console.WriteLine($"Price Per Unit: {warehouse.PricePerUnit}");
                Console.WriteLine($"Total Value: {warehouse.PricePerUnit * warehouse.Quantity}");
            }
        }
    }
}