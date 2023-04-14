using System;

class Program
{
    static void Main(string[] args)
    {
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        // Warrior with Clothes and Weapons
        IInventory warriorInventory1 = new Weapons(new Clothes(null));
        Console.WriteLine("Warrior 1: " + warriorInventory1.Apply(warrior));

        // Mage with Clothes and Artifacts
        IInventory mageInventory1 = new Artifacts(new Clothes(null));
        Console.WriteLine("Mage 1: " + mageInventory1.Apply(mage));

        // Paladin with Clothes, Weapons, and Artifacts
        IInventory paladinInventory1 = new Artifacts(new Weapons(new Clothes(null)));
        Console.WriteLine("Paladin 1: " + paladinInventory1.Apply(paladin));

        // Warrior with only Weapons
        IInventory warriorInventory2 = new Weapons(null);
        Console.WriteLine("Warrior 2: " + warriorInventory2.Apply(warrior));

        // Mage with only Artifacts
        IInventory mageInventory2 = new Artifacts(null);
        Console.WriteLine("Mage 2: " + mageInventory2.Apply(mage));

        // Paladin with only Clothes
        IInventory paladinInventory2 = new Clothes(null);
        Console.WriteLine("Paladin 2: " + paladinInventory2.Apply(paladin));
    }
}
