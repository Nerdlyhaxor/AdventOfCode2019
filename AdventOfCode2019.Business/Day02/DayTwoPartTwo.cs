using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic
{
	public class DayTwoPartTwo
	{
		private readonly List<int> commands;

		public DayTwoPartTwo(string programText) =>
			this.commands = !string.IsNullOrEmpty(programText) ?
				programText
					.Split(',')
					.Select(Int32.Parse)
					.ToList() : new List<int>();

		public int Solve(int noun, int verb) =>
			this.commands
				.ReplaceNounAndVerb(noun, verb)
				.ProcessCommands()[0];
	}

	internal static class DayTwoPartTwoHelperClass
	{
		internal static List<int> ReplaceNounAndVerb(this List<int> commands, int noun, int verb) =>
			new List<int>(commands)
			{
				[1] = noun,
				[2] = verb
			};

		internal static List<int> ProcessCommands(this List<int> commands)
		{
			var opCodeOffset = 0;

			var opCode = commands[opCodeOffset];

			while (opCode != 99)
			{
				var valueOnePosition = commands[opCodeOffset + 1];
				var valueTwoPosition = commands[opCodeOffset + 2];
				var outputPosition = commands[opCodeOffset + 3];

				switch (opCode)
				{
					case 1:
						commands[outputPosition] = commands[valueOnePosition] + commands[valueTwoPosition];
						break;
					case 2:
						commands[outputPosition] = commands[valueOnePosition] * commands[valueTwoPosition];
						break;
					case 99:
						continue;
					default:
						throw new Exception($"Unknown OpCode {opCode}");
				}

				opCodeOffset += 4;
				opCode = commands[opCodeOffset];
			}

			return commands;
		}
	}
}
