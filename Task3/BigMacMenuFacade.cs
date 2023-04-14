public class BigMacMenuFacade
{
    private readonly BigMac _bigMac;
    private readonly Fries _fries;
    private readonly SoftDrink _softDrink;
    private readonly Packaging _packaging;
    private readonly Napkins _napkins;
    private readonly Prices _prices;

    public BigMacMenuFacade()
    {
        _bigMac = new BigMac();
        _fries = new Fries();
        _softDrink = new SoftDrink();
        _packaging = new Packaging();
        _napkins = new Napkins();
        _prices = new Prices();
    }

    public void PrepareMenu()
    {
        Console.WriteLine(_bigMac.Prepare());
        Console.WriteLine(_fries.Prepare());
        Console.WriteLine(_softDrink.Prepare());
        Console.WriteLine(_packaging.Prepare());
        Console.WriteLine(_napkins.Prepare());
        Console.WriteLine(_prices.Display());
    }
}
