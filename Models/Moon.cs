namespace Space_galaxies.Models
{
    internal class Moon
    {
        public string PlanetName { get; set; }
        public string Name { get; set; }

        public Moon(string planetName, string name)
        {
            PlanetName = planetName;
            Name = name;
        }
    }
}
