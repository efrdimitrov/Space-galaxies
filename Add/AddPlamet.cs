using System.Collections.Generic;
using Space_galaxies.Models;
using System.Linq;

namespace Space_galaxies.Add
{
    internal class AddPlamet
    {
        public static void AddPlanetArticle(string starName, string name, string type, string supportLife, List<Star> stars, List<Planet> planets)
        {
            var existStar = stars.FirstOrDefault(o => o.Name == starName);
            string[] existTypeStar = {
                "terrestrial", "giant planet", "ice giant", "mesoplanet", "mini-neptune", "planetar", "super-earth", "super-jupiter", "sub-earth"
            };

            System.Console.WriteLine("{"+ type + "}");

            if (existStar != null && existTypeStar.Contains(type))
            {
                var newPlanet = new Planet(starName, name, type, supportLife);
                planets.Add(newPlanet);
            }
        }
    }
}
