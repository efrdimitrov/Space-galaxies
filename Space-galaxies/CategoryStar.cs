using System;

namespace Space_galaxies
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

            string categoryStar = "";

            if (t >= 30000 && l >= 30000 && m >= 16 && s >= 6.6)
                categoryStar = "O";
            else if (t > 10000 && l > 25 && m > 2.1 && s > 1.8)
                categoryStar = "B";
            else if (t > 7500 && l > 5 && m > 1.4 && s > 1.4)
                categoryStar = "A";
            else if (t > 6000 && l > 1.5 && m > 1.04 && s > 1.15)
                categoryStar = "F";
            else if (t > 5200 && l > 0.6 && m > 0.8 && s > 0.96)
                categoryStar = "G";
            else if (t > 3700 && l > 0.08 && m > 0.45 && s > 0.7)
                categoryStar = "K";
            else if (t >= 2400 && m >= 0.08)
                categoryStar = "M";
            Console.WriteLine($"         Class: {categoryStar} ({m},{s},{t},{l})");

        }
    }
}
