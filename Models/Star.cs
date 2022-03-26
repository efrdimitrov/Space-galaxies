namespace Space_galaxies.Models
{
    internal class Star
    {
        public Star(string galaxyName, string name, string category)
        {
            GalaxyName = galaxyName;
            Name = name;
            Category = category;
        }
        public string GalaxyName { get; set; }
        public string Name { get; set; }    
        public string Category { get; set; }


    }
}
