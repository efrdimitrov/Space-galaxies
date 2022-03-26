namespace Space_galaxies.Models
{
    internal class Planet
    {
        public string StarName { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SupportLife { get; set; }

        public Planet(string starName, string name, string type, string supportLife)
        {
            StarName = starName;
            Name = name;
            Type = type;
            SupportLife = supportLife;
        }
    }
}
