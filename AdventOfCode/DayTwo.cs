using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode;
public class DayTwo
{
    public DayTwo()
    {
        string[] input = File.ReadAllLines(@"C:\Users\johan\adventofcode\mock.txt");

       // Console.WriteLine($"Part one {SolveFirst(input)}");
        Console.WriteLine($"Part two {SolveSecond(input)}");

    }
    static int SolveFirst(string[] input)
    {
        var forward = 0;
        var depth = 0;

        foreach (var line in input)
        {
            var direction = line.Split(' ')[0];
            switch (direction)
            {
                case "forward":
                    var f = line.Split(' ');
                    forward += int.Parse(f[1]);
                    break;
                case "down":
                    var d = line.Split(' ');
                    depth -= int.Parse(d[1]);
                    break;
                case "up":
                    var u = line.Split(' ');
                    depth += int.Parse(u[1]);
                    break;
            }
        }

        return forward * depth * -1;
    }

    static int SolveSecond(string[] input)
    {
        var horizontal = 0;
        var aim = 0;
        var depth = 0;

        foreach (var line in input)
        {
            var direction = line.Split(' ')[0];
            switch (direction)
            {
                case "forward":
                    var f = line.Split(' ');
                    if (aim > 0)
                    {
                        horizontal += (int.Parse(f[1]));
                        depth += (int.Parse(f[1]) * aim);
                    }
                    else
                    {
                        horizontal += int.Parse(f[1]);
                    }
                    break;
                case "down":
                    var d = line.Split(' ');
                    aim += int.Parse(d[1]);
                    break;
                case "up":
                    var u = line.Split(' ');
                    aim -= int.Parse(u[1]);
                    break;
            }
        }

        return horizontal * depth;
    }
}
