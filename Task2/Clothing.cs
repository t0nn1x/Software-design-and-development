using System;

namespace ClothingFactory
{
    public abstract class Clothing
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public abstract void Display();
    }

    public class MenClothing : Clothing
    {
        public MenClothing(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Display()
        {
            Console.WriteLine($"Men's {Type}: {Name}");
        }
    }

    public class WomenClothing : Clothing
    {
        public WomenClothing(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Display()
        {
            Console.WriteLine($"Women's {Type}: {Name}");
        }
    }

    public class ChildrenClothing : Clothing
    {
        public ChildrenClothing(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override void Display()
        {
            Console.WriteLine($"Children's {Type}: {Name}");
        }
    }
}
