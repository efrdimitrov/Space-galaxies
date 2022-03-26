using System;
using System.Collections.Generic;
using Space_galaxies.Models;

namespace Space_galaxies.Commands
{
    internal class Stats
    {
        public static void StatsArticle(string input, List<Galaxy> galaxies, List<Star> stars, List<Planet> planets, List<Moon> moons)
        {
            if (input.Equals("stats") && galaxies.Count > 0)
            {
                Console.WriteLine("--- Stats ---");
                Console.WriteLine($"Galaxies: {galaxies.Count}");
                if (stars.Count > 0)
                    Console.WriteLine($"Stars: {stars.Count}");
                if (planets.Count > 0)
                    Console.WriteLine($"Planets: {planets.Count}");
                if (moons.Count > 0)
                    Console.WriteLine($"Monns: {moons.Count}");
                Console.WriteLine("--- End of stats ---");
            }
        }
    }
}
