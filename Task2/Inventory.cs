public interface IInventory
{
    string Apply(Hero hero);
}

public abstract class InventoryDecorator : IInventory
{
    private readonly IInventory _inventory;

    protected InventoryDecorator(IInventory inventory)
    {
        _inventory = inventory;
    }

    public virtual string Apply(Hero hero)
    {
        return _inventory?.Apply(hero);
    }
}

public class Clothes : InventoryDecorator
{
    public Clothes(IInventory inventory) : base(inventory) { }

    public override string Apply(Hero hero)
    {
        return $"{base.Apply(hero)} with Clothes";
    }
}

public class Weapons : InventoryDecorator
{
    public Weapons(IInventory inventory) : base(inventory) { }

    public override string Apply(Hero hero)
    {
        return $"{base.Apply(hero)} with Weapons";
    }
}

public class Artifacts : InventoryDecorator
{
    public Artifacts(IInventory inventory) : base(inventory) { }

    public override string Apply(Hero hero)
    {
        return $"{base.Apply(hero)} with Artifacts";
    }
}
