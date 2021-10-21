using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroweapon, villainWeapon;
            hero = RandomHero();
            heroweapon  = RandomWeapon();
            Console.WriteLine($"Random hero: {hero}");
            villain = RandomVillain();
            villainWeapon = RandomWeapon(); 
            Console.WriteLine($"{hero} will fight {villain}");
            Console.WriteLine($"{hero} will fight with {heroweapon}");
            Console.WriteLine($"{villain} will fight with {villainWeapon}");
            
        }


        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] hero = { "Batman", "Spongebob", "Spiderman", "Patric" };

            return hero[RandomIndex(hero)];
        }

        private static string RandomVillain()
        {
            String[] villain = { "Peppa Big", "Mirjam", "Elise" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            string randomVillain = villain[randomIndex];
            return randomVillain; 
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "axe", "sword", "pistol" };

            return weapon[RandomIndex(weapon)];
        }
    }
}
