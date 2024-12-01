using BenchmarkDotNet.Attributes;

namespace AoC2024;

public class Day1
{
    public void Solve(string path)
    { 
        List<int> left = new List<int>();
        List<int> right= new List<int>();
        
        using var fileStream = new FileStream(path, FileMode.Open);
        using var streamReader = new StreamReader(fileStream);
        
        string line = String.Empty;
        while ((line = streamReader.ReadLine()) is not null)
        {
            string[] parts = line.Split(" ");
            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[3]));
        }
        
        left.Sort();
        right.Sort();

        int sum = 0;

        for (int i = 0; i < left.Count; i++)
        {
            sum += Math.Abs(left[i] - right[i]);
        }
        Console.WriteLine(sum);
    }
}

public class Day1Benchmark
{
    private readonly Day1 _day1 = new Day1();

    [Benchmark]
    public void SolveTask1()
    {
        _day1.Solve("./input/day1.txt");
    }
    
    [Benchmark]
    public void SolveTask2()
    {
        _day1.Solve("./input/day1.txt");
    }
}