public abstract class Hero
{
    public abstract string Describe();
}

public class Warrior : Hero
{
    public override string Describe()
    {
        return "Warrior";
    }
}

public class Mage : Hero
{
    public override string Describe()
    {
        return "Mage";
    }
}

public class Paladin : Hero
{
    public override string Describe()
    {
        return "Paladin";
    }
}
