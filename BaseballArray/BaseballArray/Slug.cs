using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballArray
{
    class Slug
    {
        public int playerSlug { get; private set; }
        double single;
        double doubles;
        double triple;
        double home;
        double batNumber;
        double calculateSlugg;

        public Slug(double single, double doubles, double triple, double home, double batNumber) //constructor
        {
            this.single = single;
            this.doubles = doubles;
            this.triple = triple;
            this.home = home;
            this.batNumber = batNumber;

        }

        public double[] StoreStat(double single, double doubles, double triple, double home, double batNumber) //store userinput into an array
        {

            double[] scoreStat = new double[] { single, doubles, triple, home, batNumber }; //Array 
            return scoreStat;

        }

        public void CalculateSlugg(double[] storeStat) //Pass array into calculateSlugg 
        {
            calculateSlugg = (storeStat[0] + 2 * storeStat[1] + 3 * storeStat[2] + 4 * storeStat[3]) / (storeStat[4]);
            Console.WriteLine("Your Slugg Score is:{0}", calculateSlugg);
        }
    }
}

 
