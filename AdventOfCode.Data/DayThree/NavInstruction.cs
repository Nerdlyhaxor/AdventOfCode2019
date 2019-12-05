using AdventOfCode.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day03
{
	public class NavInstruction
	{
		public Direction NavDirection { get; set; }
		public int Number { get; set; }

		public static List<NavInstruction> ParseString(string value) =>
			value
				.Split(',')
				.Select(o => ParseEntry(o))
				.ToList();

		public static NavInstruction ParseEntry(string entry)
		{
			var match = Regex.Match(entry, RegexPattern);

			if (!match.Success)
				throw new Exception("Bad direction entry.");

			return new NavInstruction()
			{
				NavDirection = ParseDirection(match.Groups[1].Value),
				Number = match.Groups[2].Value.ToInt()
			};
		}

		public static Direction ParseDirection(string value) =>
			value switch
			{
				"U" => Direction.Up,
				"D" => Direction.Down,
				"L" => Direction.Left,
				"R" => Direction.Right,
				_ => throw new Exception("Unexpected value for direction.")
			};

		public static string RegexPattern
		{
			get { return @"^(U|D|R|L)(\d+)$"; }
		}

		public override bool Equals(object obj)
		{
			var instruction = obj as NavInstruction;

			return this.NavDirection == instruction.NavDirection
				&& this.Number == Number;
		}

		public override int GetHashCode()
		{
			//Found at: https://www.loganfranken.com/blog/692/overriding-equals-in-c-part-2/
			unchecked
			{
				// Choose large primes to avoid hashing collisions
				const int HashingBase = (int)2166136261;
				const int HashingMultiplier = 16777619;

				int hash = HashingBase;
				hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, NavDirection) ? NavDirection.GetHashCode() : 0);
				hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Number) ? Number.GetHashCode() : 0);
				return hash;
			}
		}
	}
}
