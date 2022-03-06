using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_galaxies.Models
{
    internal class CategoryStar
    {
        public static void CalculateClassStar(string sCategory)
        {
            string[] sCategoryList = sCategory.Split(' ');

            double m = double.Parse(sCategoryList[0], System.Globalization.CultureInfo.InvariantCulture);
            double s = double.Parse(sCategoryList[1], System.Globalization.CultureInfo.InvariantCulture) / 2;
            int t = Int32.Parse(sCategoryList[2]);
            double l = double.Parse(sCategoryList[3], System.Globalization.CultureInfo.InvariantCulture);

            if (t >= 30000 && l >= 30000 && m >= 16 && s >= 6.6)
            {
                Console.WriteLine($"Class: O ({m},{s},{t},{l})");
            }
            else if(t >= 10000 && t < 30000 && l >= 25 && l < 30000 && m >= 2.1 && m < 16 && s >= 1.8 && s < 6.6)
            {
                Console.WriteLine($"Class: B ({m},{s},{t},{l})");
            }
            else if(t >= 7500 && t < 10000 && l >= 5 && l < 25 && m >= 1.4 && m < 2.1 && s >= 1.4 && s < 1.8)
            {
                Console.WriteLine($"Class: A ({m},{s},{t},{l})");
            }
            else if(t >= 6000 && t < 7500 && l >= 1.5 && l < 5 && m >= 1.04 && m < 1.4 && s >= 1.15 && s < 1.4)
            {
                Console.WriteLine($"Class: F ({m},{s},{t},{l})");
            }
            else if(t >= 5200 && t < 6000 && l >= 0.6 && l < 1.5 && m >= 0.8 && m < 1.04 && s >= 0.96 && s < 1.15)
            {
                Console.WriteLine($"Class: G ({m},{s},{t},{l})");
            }
            else if(t >= 3700 && t < 5200 && l >= 0.08 && l < 0.6 && m >= 0.45 && m < 0.8 && s >= 0.7 && s < 0.96)
            {
                Console.WriteLine($"Class: K ({m},{s},{t},{l})");
            }
            else
            {
                Console.WriteLine($"Class: M ({m},{s},{t},{l})");
            }
        }
    }
}
