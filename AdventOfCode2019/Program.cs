using com.nerdlyhaxor.AdventOfCode.Logic;
using System;
using System.IO;
using System.Reflection;

namespace com.nerdlyhaxor.AdventOfCode
{
	public static class Program
	{
		public static void Main(/*string[] args*/)
		{
			SolveDayTwoPartTwo();
		}

		public static void SolveDayTwoPartOne()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), @"InputFiles\input-2-1.txt");

			Console.WriteLine(path);

			using (var reader = new StreamReader(path))
			{
				var line = reader.ReadLine();

				var results = new DayTwoPartOne(line).Solve();

				Console.WriteLine($"Results for Day Two Part One: {results[0]}");
			}
		}

		public static void SolveDayTwoPartTwo()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), @"InputFiles\input-2-1.txt");

			Console.WriteLine(path);

			using (var reader = new StreamReader(path))
			{
				var line = reader.ReadLine();

				var dayTwoPartTwo = new DayTwoPartTwo(line);

				for (var noun = 0; noun <= 99; noun++)
					for (var verb = 0; verb <= 99; verb++)
					{
						var answer = dayTwoPartTwo.Solve(noun, verb);

						if (answer == 19690720)
						{
							Console.WriteLine($"Noun: {noun}");
							Console.WriteLine($"Verb: {verb}");
							break;
						}
					}
			}
		}
	}
}
