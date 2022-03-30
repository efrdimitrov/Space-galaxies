using Space_galaxies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static Space_galaxies.Commands.List;
using static Space_galaxies.Commands.Print;
using static Space_galaxies.Commands.Stats;
using static Space_galaxies.Add.AddGalaxy;
using static Space_galaxies.Add.AddStar;
using static Space_galaxies.Add.AddPlamet;
using static Space_galaxies.Add.AddMoon;

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
                string strInput = string.Format(string.Join(" ", input));
                string[] article = strInput.Split(new Char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                // exit and stats
                if (input.Length == 1)
                {
                    if (input[0].Equals("exit"))
                        break;
                    StatsArticle(input[0], galaxies, stars, planets, moons);
                }

                // list 
                else if (input.Length == 2)
                {
                    string listArticle = input[1];
                    ListArticle(listArticle, galaxies, stars, planets, moons);
                }

                //print
                else if (input[0].Equals("print"))
                {
                    string gName = article[1];
                    PrintGalaxy(gName, galaxies, stars, planets, moons);
                }
                else
                {
                    string inputArt = input[1];

                    if (inputArt == "galaxy")
                    {
                        var nameG = article[1];
                        var typeG = input[input.Length - 2];
                        var ageG = input[input.Length - 1];

                        AddGalaxyArticle(nameG, typeG, ageG, galaxies);
                    }

                    if (inputArt == "star")
                    {
                        string galaxyName = article[1];
                        var nameS = article[3];
                        var categoryS = article[4].Trim();

                        AddStarArticle(galaxyName, nameS, categoryS, galaxies, stars);
                    }

                    if (inputArt == "planet")
                    {
                        string starName = article[1];
                        string name = article[3];
                        string type = input[input.Length - 2];
                        string supportLife = input.LastOrDefault();

                        AddPlanetArticle(starName, name, type, supportLife, stars, planets);
                    }

                    if (inputArt == "moon")
                    {
                        string planetName = article[1];
                        string name = article[3];

                        AddMoonArticle(planetName, name, planets, moons);
                    }
                }
            }
        }
    }
}
