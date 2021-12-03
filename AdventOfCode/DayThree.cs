using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class DayThree
    {
        public DayThree()
        {
            string[] input = File.ReadAllLines(@"C:\Users\jkjellst\adventofcode\input3.txt");

            // Console.WriteLine($"Part one {SolveFirst(input)}");
            Console.WriteLine($"Part two {SolveSecond(input)}");
        }

        public static int SolveFirst(string[] input)
        {
            var gamma = "";
            var epsilon = "";

            for (int i = 0; i < input[0].Length; i++)
            {
                var zero = 0;
                var one = 0;

                foreach (var line in input)
                {
                    var character = line[i] == '0' ? zero++ : one++;
                }

                gamma += zero > one ? "0" : "1";
                epsilon += zero > one ? "1" : "0";
            }

            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        public static List<string> Helper(List<string> input, int index)
        {
            List<string> list = new List<string>();
            int ones = 0;
            int zeros = 0;

            foreach (string nums in input)
            {
                if (nums[index] == '1')
                {
                    ones++;
                }
                else
                {
                    zeros++;
                }
            }
            foreach (string line in input)
            {
                if (ones >= zeros)
                {
                    if (line[index] == '1')
                    {
                        list.Add(line);
                    }
                }
                if (zeros > ones)
                {
                    if (line[index] == '0')
                    {
                        list.Add(line);
                    }
                }
            }
           

            return list;
        }

        public static List<string> Helper2(List<string> input, int index)
        {
            List<string> list = new List<string>();
            int ones = 0;
            int zeros = 0;

            foreach (string nums in input)
            {
                if (nums[index] == '1')
                {
                    ones++;
                }
                else
                {
                    zeros++;
                }
            }
            foreach (string line in input)
            {
                if (ones >= zeros)
                {
                    if (line[index] == '1')
                    {
                        list.Add(line);
                    }
                }
                if (zeros >= ones)
                {
                    if (line[index] == '0')
                    {
                        list.Add(line);
                    }
                }
            }


            return list;
        }
        public static int SolveSecond(string[] input)
        {
            List<string> list = new List<string>(input);
            List<string> list2 = new List<string>(input);

            var scrubberRating = list[0];
            var xaRating = list2[0];

            for (int i = 0; input[0].Length > i; i++)
            {
                list = Helper(list, i);
                list2 = Helper2(list2, i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item + " " +"MONKA");
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item + " " + "TOS");
            }
           // Console.WriteLine(list[0] + " " + list2[0]);
            return Convert.ToInt32("001110100101", 2) * Convert.ToInt32("111000100110", 2);
            //
           
            //return (Convert.ToInt32(generatorRating, 2) * Convert.ToInt32(scrubberRating, 2)).ToString();
        }
    }
}
