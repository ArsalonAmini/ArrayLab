using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballArray
{
    class Program
    {
        public int playerSlug { get; private set; }
        int single;
        int doubles;
        int triple;
        int home;
        int batNumber;

        static void Main(string[] args)
        {
            //user input stats
            Console.WriteLine("Please input single's statistics");
            single = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input doubles statistics");
            doubles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input triple statistics");
            triple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input home run statistics");
            home = Convert.ToInt32(Console.ReadLine()); }

            //Function #1 store players stats inside an array 
            public void StatArray(int single, int doubles, int triple, int home)
        {
  
            int[] statArray = {single, doubles, triple, home};
            Console.WriteLine(statArray);
        }
        //Function #2 function to calculate a player's slugging percentage
        public void slugPercent(double[] statArray)
        {
                playerSlug[] = (statArray[0] + 2 * doubles + 3 * triple + 4 * home) / (batNumber);
                Console.WriteLine(playerSlug[i]);
            }
        }

        }
    }


