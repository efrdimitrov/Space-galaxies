using System.Collections.Generic;
using Space_galaxies.Models;
using System.Linq;

namespace Space_galaxies.Add
{
    internal class AddMoon
    {
        public static void AddMoonArticle(string planetName, string name, List<Planet> planets, List<Moon> moons)
        {
            var existPlanet = planets.FirstOrDefault(o => o.Name == planetName);
            if (existPlanet != null)
            {
                var newMoon = new Moon(planetName, name);
                moons.Add(newMoon);
            }

        }
    }
}
