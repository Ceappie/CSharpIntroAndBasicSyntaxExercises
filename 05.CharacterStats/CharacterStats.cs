﻿using System;


namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var character = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {character}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string ('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string ('.', maxEnergy - currentEnergy));
        }
    }
}
