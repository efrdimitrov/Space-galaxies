using System;
using System.Collections.Generic;
using System.Linq;
using Space_galaxies.Models;

namespace Space_galaxies.Commands
{
    internal class List
    {
        public static void ListArticle(string listArticle, List<Galaxy> galaxies, List<Star> stars, List<Planet> planets, List<Moon> moons)
        {
            if (listArticle == "galaxies")
            {
                if (galaxies.Count < 1)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    Console.WriteLine("--- List of all researched galaxies ---");

                    string listG = string.Join(", ", galaxies.Select(x => x.Name));
                    Console.WriteLine(listG);

                    Console.WriteLine("--- End of galaxies list ---");
                }
            }
            else if (listArticle == "stars")
            {
                if(stars.Count < 1)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    Console.WriteLine("--- List of all researched stars ---");

                    string listS = string.Join(", ", stars.Select(x => x.Name));
                    Console.WriteLine(listS);

                    Console.WriteLine("--- End of stars list ---");
                }
            }
            else if (listArticle == "planets")
            {
                if (planets.Count < 1)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    Console.WriteLine("--- List of all researched planets ---");

                    string listP = string.Join(", ", planets.Select(x => x.Name));
                    Console.WriteLine(listP);

                    Console.WriteLine("--- End of planets list ---");
                }
            }
            else
            {
                if(moons.Count < 1)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    Console.WriteLine("--- List of all researched moons ---");

                    string listM = string.Join(", ", moons.Select(x => x.Name));
                    Console.WriteLine(listM);

                    Console.WriteLine("--- End of moons list ---");
                }
            }
        }
    }
}
