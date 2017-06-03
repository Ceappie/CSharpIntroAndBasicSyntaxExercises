using System;


namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            energy = energy * (volume / 100);
            sugar = sugar * (volume / 100);
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
