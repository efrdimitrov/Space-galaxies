using System;
using System.Collections.Generic;
using System.Text;
using static Space_galaxies.CategoryStar;
using Space_galaxies.Models;

namespace Space_galaxies.Commands
{
    internal class Print
    {
        public static void PrintGalaxy(string gName, List<Galaxy> galaxies, List<Star> stars, List<Planet> planets, List<Moon> moons)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var g in galaxies)
            {
                if (g.Name.Equals(gName))
                {
                    Console.WriteLine($"--- Data for {gName} galaxy ---");
                    Console.WriteLine("Type: " + g.Type);
                    Console.WriteLine("Age: " + g.Age);

                    if (stars.Count == 0)
                        Console.WriteLine($"Stars: none");
                    foreach (var s in stars)
                    {
                        if (gName.Equals(s.GalaxyName))
                        {
                            Console.WriteLine($"Stars:");
                            Console.WriteLine($"    -    Name: {s.Name}");
                            CalculateClassStar(s.Category);

                            if (planets.Count == 0)
                                Console.WriteLine("         Planets: none");
                            foreach (var p in planets)
                            {
                                if (s.Name.Equals(p.StarName))
                                {
                                    Console.WriteLine($"         Planets:");
                                    Console.WriteLine($"             o    Name: {p.Name}");
                                    Console.WriteLine($"                  Type: {p.Type}");
                                    Console.WriteLine($"                  Support life: {p.SupportLife}");

                                    if (moons.Count == 0)
                                        Console.WriteLine("                  Moons: none");
                                    foreach (var m in moons)
                                    {
                                        if (p.Name.Equals(m.PlanetName))
                                        {
                                            Console.WriteLine($"                  Moons: ");
                                            Console.WriteLine($"                        Name: {m.Name}");
                                        }
                                        else
                                            Console.WriteLine("                  Moons: none");
                                    }
                                }
                                else
                                    Console.WriteLine("         Planets: none");
                            }
                        }
                        else
                            Console.WriteLine($"Stars: none");
                    }
                    Console.WriteLine($"--- End of data for {gName} galaxy ---");
                }
            }
        }
    }
}
