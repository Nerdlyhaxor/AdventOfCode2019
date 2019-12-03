using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic
{
	public class DayTwoPartOne
	{
		private readonly List<int> commands;

		public DayTwoPartOne(string programText) =>
			this.commands = programText
				.Split(',')
				.Select(o => Int32.Parse(o))
				.ToList();

		private List<int> ProcessCommands(List<int> commands)
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

		public List<int> Solve() =>
			this.ProcessCommands(this.commands);
	}
}
