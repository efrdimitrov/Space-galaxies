using System.Collections.Generic;
using System.Linq;
using Space_galaxies.Models;

namespace Space_galaxies.Add
{
    internal class AddGalaxy
    {
        public static void AddGalaxyArticle(string name, string type, string age, List<Galaxy> galaxies)
        {
            string[] existTypeGalaxy = { "elliptical", "lenticular", "spiral", "irregular" };

            if (existTypeGalaxy.Contains(type))
            {
                var newGalaxy = new Galaxy(name, type, age);
                galaxies.Add(newGalaxy);
            }
        }
    }
}
