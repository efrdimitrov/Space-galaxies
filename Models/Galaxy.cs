namespace Space_galaxies.Models
{
    internal class Galaxy
    {
        public string Name { get; set; }        
        public string Type { get; set; }
        public string Age { get; set; }

        public Galaxy(string name, string type, string age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }

    }
}
