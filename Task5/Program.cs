// Task 5: Builder.
// 1. Create a HeroBuilder class that will create a character
// of the game, gradually adding various features to it, such as height,
// physique, hair color, eyes, clothes, equipment, etc. (you can use your imagination).
// your imagination).
// 2. Create an EnemyBuilder class that will implement a single
// interface with HeroBuilder.
// 3. With the help of your builder and class director, create the hero
// (or heroine) of your dreams 🙂, as well as your worst enemy.
// 4. Show the correctness of your code by running it in the
// the main method of the program

using System;

namespace Builder
{
    public class HeroBuilder
    {
        public HeroBuilder()
        {
            Hero = new Hero();
        }

        public Hero Hero { get; }

        public HeroBuilder SetHeight(int height)
        {
            Hero.Height = height;
            return this;
        }

        public HeroBuilder SetPhysique(string physique)
        {
            Hero.Physique = physique;
            return this;
        }

        public HeroBuilder SetHairColor(string hairColor)
        {
            Hero.HairColor = hairColor;
            return this;
        }

        public HeroBuilder SetEyes(string eyes)
        {
            Hero.Eyes = eyes;
            return this;
        }

        public HeroBuilder SetClothes(string clothes)
        {
            Hero.Clothes = clothes;
            return this;
        }

        public HeroBuilder SetEquipment(string equipment)
        {
            Hero.Equipment = equipment;
            return this;
        }
    }

    public class Hero
    {
        public int Height { get; set; }
        public string Physique { get; set; }
        public string HairColor { get; set; }
        public string Eyes { get; set; }
        public string Clothes { get; set; }
        public string Equipment { get; set; }
    }

    public class EnemyBuilder
    {
        public EnemyBuilder()
        {
            Enemy = new Enemy();
        }

        public Enemy Enemy { get; }

        public EnemyBuilder SetHeight(int height)
        {
            Enemy.Height = height;
            return this;
        }

        public EnemyBuilder SetPhysique(string physique)
        {
            Enemy.Physique = physique;
            return this;
        }

        public EnemyBuilder SetHairColor(string hairColor)
        {
            Enemy.HairColor = hairColor;
            return this;
        }

        public EnemyBuilder SetEyes(string eyes)
        {
            Enemy.Eyes = eyes;
            return this;
        }

        public EnemyBuilder SetClothes(string clothes)
        {
            Enemy.Clothes = clothes;
            return this;
        }

        public EnemyBuilder SetEquipment(string equipment)
        {
            Enemy.Equipment = equipment;
            return this;
        }
    }

    public class Enemy
    {
        public int Height { get; set; }
        public string Physique { get; set; }
        public string HairColor { get; set; }
        public string Eyes { get; set; }
        public string Clothes { get; set; }
        public string Equipment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var heroBuilder = new HeroBuilder();
            var hero = heroBuilder.SetHeight(180).SetPhysique("Athletic").SetHairColor("Black").SetEyes("Blue").SetClothes("T-shirt").SetEquipment("Sword").Hero;

            var enemyBuilder = new EnemyBuilder();
            var enemy = enemyBuilder.SetHeight(200).SetPhysique("Creepy").SetHairColor("Green").SetEyes("Blue").SetClothes("Without").SetEquipment("Bow").Enemy;

            Console.WriteLine("Hero:");
            Console.WriteLine($"Height: {hero.Height}");
            Console.WriteLine($"Physique: {hero.Physique}");
            Console.WriteLine($"Hair color: {hero.HairColor}");
            Console.WriteLine($"Eyes: {hero.Eyes}");
            Console.WriteLine($"Clothes: {hero.Clothes}");
            Console.WriteLine($"Equipment: {hero.Equipment}");

            Console.WriteLine("*" + new string('-', 50) + "*");

            Console.WriteLine("Enemy:");
            Console.WriteLine($"Height: {enemy.Height}");
            Console.WriteLine($"Physique: {enemy.Physique}");
            Console.WriteLine($"Hair color: {enemy.HairColor}");
            Console.WriteLine($"Eyes: {enemy.Eyes}");
            Console.WriteLine($"Clothes: {enemy.Clothes}");
            Console.WriteLine($"Equipment: {enemy.Equipment}");
        }
    }


    
}