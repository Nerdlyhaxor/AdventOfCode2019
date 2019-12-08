using com.nerdlyhaxor.AdventOfCode.Logic;
using com.nerdlyhaxor.AdventOfCode.Logic.Day02;
using com.nerdlyhaxor.AdventOfCode.Logic.Day04;
using com.nerdlyhaxor.AdventOfCode.Util;
using System;
using System.Collections.Generic;
using System.IO;

namespace com.nerdlyhaxor.AdventOfCode
{
	public static class Program
	{
		public static void Main(/*string[] args*/)
		{
			var puzzles = Init();

			foreach(var puzzle in puzzles)
			{
				var fileName = GetFullFileName(puzzle.FileName);
				var answer = puzzle.Solver.Solve(fileName);

				Console.WriteLine($"Answer for Day {puzzle.Day} Part {puzzle.Part} is {answer}.");
			}
		}

		public static List<AdventOfCodePuzzle> Init() =>
				new List<AdventOfCodePuzzle>()
				{
					new AdventOfCodePuzzle() { Day = 4, Part = 1, Solver = new DayFourPartOne() }
				};

		public static string GetFullFileName(string fileName) =>
			Path.Combine(Directory.GetCurrentDirectory(), $"InputFiles\\{fileName}");

		public static void SolveDayTwoPartOne()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), @"InputFiles\input-2-1.txt");

			Console.WriteLine(path);

			using var reader = new StreamReader(path);

			var line = reader.ReadLine();

			var results = new DayTwoPartOne(line)
				.Solve();

			Console.WriteLine($"Results for Day Two Part One: {results[0]}");
		}

		public static void SolveDayTwoPartTwo()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), @"InputFiles\input-2-1.txt");

			Console.WriteLine(path);

			using var reader = new StreamReader(path);

			var line = reader.ReadLine();

			var dayTwoPartTwo = new DayTwoPartTwo(line);

			for (var noun = 0; noun <= 99; noun++)
			{
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
