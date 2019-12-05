using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day03
{
	public class Grid
	{
		public List<Wire> Wires { get; set; } = new List<Wire>();

		public List<Point> FindIntersections()
		{
			var intersections = new Dictionary<Point, int>();

			foreach (var wire in this.Wires)
				foreach (var location in wire.Locations.Where(o => !o.Equals(Point.OriginPoint)))
					if (!intersections.ContainsKey(location))
						intersections.Add(location, 1);
					else
						intersections[location]++;

			return intersections
				.Where(o => o.Value > 1)
				.Select(o => o.Key)
				.ToList();
		}
	}
}
