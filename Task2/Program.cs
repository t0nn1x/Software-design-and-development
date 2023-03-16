using System;

namespace ClothingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothingFactory casualClothingFactory = new CasualClothingFactory();
            MenClothing casualMenTshirt = casualClothingFactory.CreateMenClothing("Cotton T-shirt");
            WomenClothing casualWomenTshirt = casualClothingFactory.CreateWomenClothing("Crop Top");
            ChildrenClothing casualChildrenTshirt = casualClothingFactory.CreateChildrenClothing("Graphic T-shirt");

            Console.WriteLine("Casual Clothing Factory:");
            casualMenTshirt.Display();
            casualWomenTshirt.Display();
            casualChildrenTshirt.Display();

            ClothingFactory formalClothingFactory = new FormalClothingFactory();
            MenClothing formalMenSuit = formalClothingFactory.CreateMenClothing("Black suit");
            WomenClothing formalWomenDress = formalClothingFactory.CreateWomenClothing("Red dress");
            ChildrenClothing formalChildrenOutfit = formalClothingFactory.CreateChildrenClothing("Formal outfit");

            Console .WriteLine("\nFormal Clothing Factory:");
            formalMenSuit.Display();
            formalWomenDress.Display();
            formalChildrenOutfit.Display();
        }
    }
}
