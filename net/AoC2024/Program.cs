using AoC2024;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;

Day1 aoc2024Day1Task1 = new Day1();
aoc2024Day1Task1.Solve("./input/day1.txt");

var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<Day1Benchmark>(config, args);