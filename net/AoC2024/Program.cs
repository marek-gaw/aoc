using AoC2024;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;

Day1 aoc2024Day1Task1 = new Day1();
aoc2024Day1Task1.SolvePart1("./input/day1.txt");
aoc2024Day1Task1.SolvePart2("./input/day1.txt");


var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<Day1Benchmark>(config, args);