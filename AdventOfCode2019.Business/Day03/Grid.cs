using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day03
{
	public class Grid
	{
		public List<Wire> Wires { get; } = new List<Wire>();
		public List<Point> Intersections { get; } = new List<Point>();

		public List<Point> FindIntersections()
		{
			var intersections = new Dictionary<Point, int>();

			this.Wires
				.ForEach(wire =>
				{
					wire.Locations
						.ForEach(location =>
						{
							if (!intersections.ContainsKey(location))
								intersections.Add(location, 1);
							else
								intersections[location]++;
						});
				});

			return intersections
				.Where(o => o.Value > 1 && !o.Key.Equals(Point.OriginPoint))
				.Select(o => o.Key)
				.ToList();
		}
	}
}
