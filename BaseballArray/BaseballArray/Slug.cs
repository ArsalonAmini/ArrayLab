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
        int single;
        int doubles;
        int triple;
        int home;
        int batNumber;

        //user input stats
        Console.WriteLine("Please input single's statistics");
            single = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input doubles statistics");
            doubles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input triple statistics");
            triple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input home run statistics");
            home = Convert.ToInt32(Console.ReadLine()); }
            Console.WriteLine("Please input bat number");
            bat = Convert.ToInt32(Console.ReadLine());

    public void StatArray(int single, int doubles, int triple, int home, int bat)
    {

        int[] statArray = { single, doubles, triple, home, bat};
        Console.WriteLine(statArray);
    }

    public void slugPercent(double[] statArray)  //Function #2 function to calculate a player's slugging percentage
    {
        playerSlug[] = (statArray[0] + 2 * statArray[1] + 3 * statArray[2] + 4 * statArray[3]) / (statArray[4]);
        Console.WriteLine(playerSlug[i]);
    }
 }

 
