using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "chicken nuggets", "burger", "salad", "french fries" };
            string[] drinks = { "still water", "red bull", "vitamin well" };
            string[] movies = { "Arrow", "The vampire diaries", "Squid Game" };

            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovie = PickRandomFromArray(movies);

            Console.WriteLine($"computer picked {randomSnack} and {randomDrink} for a {randomMovie} night.");
        }
        
        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement; 
        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"computer has chosen {someArray[randomIndex]}");
            
        }
        
    }
}
