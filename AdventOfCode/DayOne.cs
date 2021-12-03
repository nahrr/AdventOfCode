namespace AdventOfCode;
public class DayOne
{
    //static void Main(string[] args)
    public DayOne()
    {
        string[] input = File.ReadAllLines(@"C:\Users\johan\adventofcode\mock.txt");
        int[] inputToInt = (Array.ConvertAll(input, x => int.Parse(x)));

        Console.WriteLine($"Part one {SolveFirst(inputToInt)}");
        Console.WriteLine($"Part two {SolveSecond(inputToInt)}");
    }
    static int SolveFirst(int[] input)
    {
        int counter = 0;

        for (int i = 1; i < input.Count(); i++)
            if (input[i] > input[i - 1])
                counter++;

        return counter;
    }
    static int SolveSecond(int[] input)
    {
        int counter = 0;

        for (int i = 1; i < input.Count() - 2; i++)
        {
            int currentLine = input[i - 1] + input[i] + input[i + 1];
            int nextLine = input[i] + input[i + 1] + input[i + 2];

            if (nextLine > currentLine)
                counter++;
        }

        return counter;
    }
}