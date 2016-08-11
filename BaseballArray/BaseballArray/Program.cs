using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballArray
{
    class Program
    {
 
        static void Main(string[] args)
        {

            //user input stats
            Console.WriteLine("Please input single's statistics");
            double single = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input doubles statistics");
            double doubles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input triple statistics");
            double triple = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input home run statistics");
            double home = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input bat number");
            double batNumber = Convert.ToDouble(Console.ReadLine());

            Slug slug = new Slug(single, doubles, triple, home, batNumber);
            double[] stats =  slug.StoreStat(single, doubles, triple, home, batNumber);
            slug.CalculateSlugg(stats);
            Console.ReadLine();
        } 
       
        }
    }


