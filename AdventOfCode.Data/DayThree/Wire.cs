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
			this.Locations = wire.Locations;

		public List<Point> Locations { get; set; } =
			new List<Point>
				{
					//Add Origin Point
					Point.OriginPoint
				};

		public Wire Navigate(string navString) =>
			this.Navigate(NavInstruction.ParseString(navString));

		public Wire Navigate(List<NavInstruction> instructions)
		{
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
