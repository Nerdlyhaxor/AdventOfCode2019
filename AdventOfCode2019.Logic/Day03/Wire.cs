using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day03
{
	public class Wire
	{
		public Wire() { }

		public Wire(Wire wire) =>
			this.Locations = wire != null ?
				wire.Locations :
				new List<Point>();

		public List<Point> Locations { get; } =
			new List<Point>
				{
					//Add Origin Point
					Point.OriginPoint
				};

		public static Wire CreateAndNavigate(string navString) =>
			new Wire().Navigate(navString);

		public Wire Navigate(string navString) =>
			this.Navigate(NavInstruction.ParseString(navString));

		public Wire Navigate(List<NavInstruction> instructions)
		{
			if (instructions == null)
				instructions = new List<NavInstruction>();

			var wire = new Wire(this);

			foreach(var instruction in instructions)
				wire.Locations.Add(wire.Move(instruction.NavDirection, instruction.Number));

			return wire;
		}

		public Point Move(Direction direction, int number) =>
			direction switch
			{
				Direction.Up => this.GetCurrentLocation().MoveUp(number),
				Direction.Down => this.GetCurrentLocation().MoveDown(number),
				Direction.Left => this.GetCurrentLocation().MoveLeft(number),
				Direction.Right => this.GetCurrentLocation().MoveRight(number),
				_ => this.GetCurrentLocation()
			};

		public Point GetCurrentLocation() =>
			this.Locations
				.Last();
	}
}
