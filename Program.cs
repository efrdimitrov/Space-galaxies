using Space_galaxies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Space_galaxies.Models.List;
using static Space_galaxies.Models.Print;

namespace Space_galaxies
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<Galaxy> galaxies = new List<Galaxy>();
        List<Star> stars = new List<Star>();
        List<Planet> planets = new List<Planet>();
        List<Moon> moons = new List<Moon>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                string strInput = string.Format( string.Join(" ", input));
                string[] article = strInput.Split(new Char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                // exit and stats
                if (input.Length == 1)
                {
                    if (input[0].Equals("exit"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("--- Stats ---");
                        Console.WriteLine($"Galaxies: {galaxies.Count}");
                        Console.WriteLine($"Stars: {stars.Count}");
                        Console.WriteLine($"Planets: {planets.Count}");
                        Console.WriteLine($"Monns: {moons.Count}");
                        Console.WriteLine("--- End of tats ---");
                    }
                }         

                // list 
                if (input.Length == 2)
                {           
                    string listArticle = input[1];
                    ListArticle(listArticle, galaxies, stars, planets, moons);                 
                }

                // add
                if(input[0].Equals("add"))
                {
                    if (input[1].Equals("galaxy"))
                    {
                        var name = article[1];
                        var type = input[input.Length - 2];
                        var age = input[input.Length - 1];

                        var newGalaxy = new Galaxy(name, type, age);
                        galaxies.Add(newGalaxy);
                    }

                    else if(input[1].Equals("star"))
                    {
                        string galaxyName = article[1];
                        var name = article[3];
                        var category = article[4].Trim();

                        bool existGalaxy = false;
                        foreach (var galaxy in galaxies)
                        {
                            if(galaxyName.Equals(galaxy.Name))
                            {
                                existGalaxy = true;
                            }
                        }

                        if(existGalaxy)
                        {
                            var newStar = new Star(galaxyName, name, category);
                            stars.Add(newStar);
                        }                  
                    }    
                    
                    else if(input[1].Equals("planet"))
                    {
                        string[] lastStr = article[4].Split(' ');

                        var starName = article[1];
                        var name = article[3];
                        var type = lastStr[1];

                        if(lastStr.Length > 3)
                        {
                            type = lastStr[1] + " " + lastStr[2];
                        }
                        var supportLife = lastStr[lastStr.Length - 1];

                        bool existStar = false;
                        foreach (var star in stars)
                        {
                            if (starName.Equals(star.Name))
                            {
                                existStar = true;
                            }
                        }

                        if (existStar)
                        {
                            var newPlanet = new Planet(starName, name, type, supportLife);
                            planets.Add(newPlanet);
                        }
                    }

                    else
                    {
                        var planetName = article[1];
                        var name = article[3];
                        bool existPlanet = false;
                        foreach(Planet planet in planets)
                        {
                            if(planetName.Equals(planet.Name))
                            {
                                existPlanet = true;
                            }
                        }

                        if (existPlanet)
                        {
                            var newMoon = new Moon(planetName, name);
                            moons.Add(newMoon);
                        }
                    }
                }

                //print
                if (input[0].Equals("print"))
                {
                    string gName = article[1];
                    PrintGalaxy(gName, galaxies, stars, planets, moons);
                }
            }
        }         
    }
}
