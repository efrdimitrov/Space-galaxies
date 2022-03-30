namespace Space_galaxies.Models
{
    internal class SpaceObject
    {
        public string Name { get; set; }
        public SpaceObject(string name)
        {
            this.Name = name;
        }
    }
}
