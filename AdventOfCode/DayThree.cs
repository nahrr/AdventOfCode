
namespace AdventOfCode
{
    public class DayThree
    {
        public DayThree()
        {
            string[] input = File.ReadAllLines(@"C:\Users\johan\adventofcode\input3.txt");
            Console.WriteLine($"Part one {SolveFirst(input)}");
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
            List<string> list= new List<string>();
            int ones = 0;
            int zeros = 0;

            if(input.Count == 1)
            {
                list.Add(input[0]);
                return list;
            }
            foreach (string nums in input)
            {
                if (nums[index] == '0')
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }
            }
            foreach (string line in input)
            {
                if (zeros <= ones)
                {
                    if (line[index] == '0')
                    {
                        list.Add(line);
                    }
                }
                if (ones < zeros)
                {
                    if (line[index] == '1')
                    {
                        list.Add(line);
                    }
                }
            }

            return list;
        }
        public static int SolveSecond(string[] input)
        {
            List<string> generatorRating = new(input);
            List<string> scrubberRating = new(input);

            for (int i = 0; input[0].Length > i; i++)
            {
                generatorRating = Helper(generatorRating, i);
                scrubberRating = Helper2(scrubberRating, i);
            }

            return Convert.ToInt32(generatorRating[0], 2) * Convert.ToInt32(scrubberRating[0], 2);
        }
    }
}
