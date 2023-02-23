namespace SOLID.Classes
{
    public class Product
    {
        // Product class - responsible for handling product operations
        // Product class - open for extension by allowing price reduction method to be added

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void ReducePrice(decimal amount)
        {
            Price -= amount;
        }
    }
}