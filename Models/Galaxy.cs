namespace Space_galaxies.Models
{
    internal class Galaxy : SpaceObject
    {
        public string Type { get; set; }
        public string Age { get; set; }

        public Galaxy(string name, string type, string age)
            : base(name)
        {
            this.Type = type;
            this.Age = age;
        }

    }
}
