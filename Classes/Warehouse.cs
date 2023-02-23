namespace SOLID.Classes
{
    public class Warehouse
    {
        // Warehouse class - responsible for handling warehouse operations

        public string Name { get; private set; }
        public string UnitOfMeasurement { get; private set; }
        public decimal PricePerUnit { get; private set; }
        public int Quantity { get; private set; }
        public DateTime DateOfLastDelivery { get; private set; }

        public Warehouse(string name, string unitOfMeasurement, decimal pricePerUnit, int quantity, DateTime dateOfLastDelivery)
        {
            Name = name;
            UnitOfMeasurement = unitOfMeasurement;
            PricePerUnit = pricePerUnit;
            Quantity = quantity;
            DateOfLastDelivery = dateOfLastDelivery;
        }

        public void ReceiveGoods(int quantity, decimal pricePerUnit, DateTime dateOfDelivery)
        {
            Quantity += quantity;
            PricePerUnit = pricePerUnit;
            DateOfLastDelivery = dateOfDelivery;
        }

        public void ShipGoods(int quantity)
        {
            Quantity -= quantity;
        }
    }
}