namespace Space_galaxies.Models
{
    internal class Moon : SpaceObject
    {
        public string PlanetName { get; set; }

        public Moon(string planetName, string name)
            : base(name)
        {
            PlanetName = planetName;
        }
    }
}
