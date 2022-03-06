using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_galaxies.Models
{
    internal class Adding
    {
        private List<Galaxy> galaxies { get; set; }
        private List<Star> stars { get; set; }
        private List<Planet> planets { get; set; }
        private List<Moon> moons { get; set; }

        public void AddGalaxy(Galaxy galaxy)
        {
            galaxies.Add(galaxy);
        }

        public void AddStar(Star star)
        {
            stars.Add(star);
        }

        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }

        private void AddMoon(Moon moon)
        {
            moons.Add(moon);
        }
        
    }
}
