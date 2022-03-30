namespace Space_galaxies.Models
{
    internal class Star : SpaceObject
    {
        public string GalaxyName { get; set; }
        public string Category { get; set; }
        public Star(string galaxyName, string name, string category)
            : base(name)
        {
            GalaxyName = galaxyName;
            Category = category;
        }


    }
}
