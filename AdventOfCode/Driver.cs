using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Driver {
        
        public static void Main(string[] args)
        {
            string line = "------------------------";

            Console.WriteLine(line);
            Console.WriteLine("Day 1");
            new DayOne();

            Console.WriteLine(line);
            Console.WriteLine("Day 2");
            new DayTwo();

            Console.WriteLine(line);
            Console.WriteLine("Day 3");
            new DayThree();


        }
    }
}
