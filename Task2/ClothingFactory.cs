using System.Collections.Generic;

namespace ClothingFactory
{
    public abstract class ClothingFactory
    {
        public abstract MenClothing CreateMenClothing(string name);
        public abstract WomenClothing CreateWomenClothing(string name);
        public abstract ChildrenClothing CreateChildrenClothing(string name);
    }

    public class CasualClothingFactory : ClothingFactory
    {
        public override MenClothing CreateMenClothing(string name)
        {
            return new MenClothing(name, "T-shirt");
        }

        public override WomenClothing CreateWomenClothing(string name)
        {
            return new WomenClothing(name, "T-shirt");
        }

        public override ChildrenClothing CreateChildrenClothing(string name)
        {
            return new ChildrenClothing(name, "T-shirt");
        }
    }

    public class FormalClothingFactory : ClothingFactory
    {
        public override MenClothing CreateMenClothing(string name)
        {
            return new MenClothing(name, "Suit");
        }

        public override WomenClothing CreateWomenClothing(string name)
        {
            return new WomenClothing(name, "Dress");
        }

        public override ChildrenClothing CreateChildrenClothing(string name)
        {
            return new ChildrenClothing(name, "Outfit");
        }
    }
}
