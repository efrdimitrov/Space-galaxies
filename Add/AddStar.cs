using System.Collections.Generic;
using Space_galaxies.Models;
using System.Linq;

namespace Space_galaxies.Add
{
    internal class AddStar
    {   
        public static void AddStarArticle(string galaxyName, string name, string category, List<Galaxy> galaxies, List<Star> stars)
        {
            var existGalaxy = galaxies.FirstOrDefault(o => o.Name == galaxyName);
            if (existGalaxy != null)
            {
                var newStar = new Star(galaxyName, name, category);
                stars.Add(newStar);
            }
        }
    }
}
