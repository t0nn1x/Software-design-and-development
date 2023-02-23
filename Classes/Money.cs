namespace SOLID.Classes
{
    public class Money
    {
        // Money class - responsible for handling money operations

        public int WholePart { get; private set; }
        public int Pennies { get; private set; }

        public Money(int wholePart, int pennies)
        {
            WholePart = wholePart;
            Pennies = pennies;
        }

        public void SetWholePart(int wholePart)
        {
            WholePart = wholePart;
        }

        public void SetPennies(int pennies)
        {
            Pennies = pennies;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"{WholePart}.{Pennies}");
        }
    }
}