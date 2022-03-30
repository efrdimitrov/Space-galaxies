namespace Space_galaxies.Models
{
    internal class Planet : SpaceObject
    {
        public string StarName { get; set; }
        public string Type { get; set; }
        public string SupportLife { get; set; }

        public Planet(string starName, string name, string type, string supportLife)
            : base(name)
        {
            StarName = starName;
            Type = type;
            SupportLife = supportLife;
        }
    }
}
