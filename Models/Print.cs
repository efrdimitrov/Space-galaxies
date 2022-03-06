using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Space_galaxies.Models.CategoryStar;

namespace Space_galaxies.Models
{
    internal class Print
    {
        public static void PrintGalaxy(string gName, List<Galaxy> galaxies, List<Star> stars, List<Planet> planets, List<Moon> moons)
        {
            Console.WriteLine($"--- Data for {gName} galaxy ---");

            foreach (var g in galaxies)
            {
                if (g.Name.Equals(gName))
                {
                    Console.WriteLine("Type: " + g.Type);
                    Console.WriteLine("Age: " + g.Age);

                    foreach (var s in stars)
                    {
                        if (gName.Equals(s.GalaxyName))
                        {
                            Console.WriteLine("Stars:");
                            Console.WriteLine($"Name: {s.Name}");
                            CalculateClassStar(s.Category);

                            foreach (var p in planets)
                            {
                                if (s.Name.Equals(p.StarName))
                                {
                                    Console.WriteLine("Planets:");
                                    Console.WriteLine($"Name: {p.Name}");
                                    Console.WriteLine($"Type: {p.Type}");
                                    Console.WriteLine($"Support life: {p.SupportLife}");

                                    foreach (var m in moons)
                                    {
                                        if (p.Name.Equals(m.PlanetName))
                                        {
                                            Console.WriteLine("Moons:");
                                            Console.WriteLine($"Name: {m.Name}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"--- End of data for {gName} galaxy ---");
        }
    }
}
