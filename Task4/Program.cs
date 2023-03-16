using System;

namespace Prototype
{
    // Virus class
    public class Virus
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public VirusChild[] Children { get; set; }

        public Virus Clone()
        {
            return new Virus
            {
                Weight = Weight,
                Age = Age,
                Name = Name,
                Species = Species,
                Children = (VirusChild[])Children.Clone()
            };
        }
    }

    // VirusChild class
    public class VirusChild
    {
        public DateTime BirthDate { get; set; }
        public Virus Parent { get; set; }

        public VirusChild Clone()
        {
            return new VirusChild
            {
                BirthDate = BirthDate,
                Parent = Parent
            };
        }
    }

    // Example usage
    class Program
    {
        static void Main(string[] args)
        {
            // Create a virus and its children
            var parent = new Virus
            {
                Weight = 10,
                Age = 5,
                Name = "ParentVirus",
                Species = "Coronavirus",
                Children = new VirusChild[]
                {
                    new VirusChild
                    {
                        BirthDate = new DateTime(2022, 1, 1)
                    },
                    new VirusChild
                    {
                        BirthDate = new DateTime(2022, 2, 1)
                    }
                }
            };

            // Clone the parent virus and its children
            var clone = parent.Clone();
            clone.Name = "CloneVirus";
            clone.Children[0].BirthDate = new DateTime(2022, 3, 1);

            // Display the results
            Console.WriteLine("Original virus:");
            DisplayVirus(parent);

            Console.WriteLine("\nCloned virus:");
            DisplayVirus(clone);

            Console.ReadLine();
        }

        static void DisplayVirus(Virus virus)
        {
            Console.WriteLine($"Name: {virus.Name}, Species: {virus.Species}, Age: {virus.Age}, Weight: {virus.Weight}");

            if (virus.Children != null)
            {
                Console.WriteLine("Children:");
                foreach (var child in virus.Children)
                {
                    Console.WriteLine($"\tBirth date: {child.BirthDate}");
                }
            }
        }
    }
}
