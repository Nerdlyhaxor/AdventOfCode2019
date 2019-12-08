using System;
using System.Collections.Generic;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day03
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		private bool IsOrigin { get; set; } = false;

		public Point MoveUp(int number) =>
			new Point() { X = this.X, Y = this.Y + number };

		public Point MoveDown(int number) =>
			new Point() { X = this.X, Y = this.Y - number };

		public Point MoveRight(int number) =>
			new Point() { X = this.X + number, Y = this.Y };

		public Point MoveLeft(int number) =>
			new Point() { X = this.X - number, Y = this.Y };

		public static Point OriginPoint
		{
			get { return new Point { X = 0, Y = 0, IsOrigin = true }; }
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
				return false;

			var point = obj as Point;

			return this.X == point.X
				&& this.Y == point.Y;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0041:Use 'is null' check", Justification = "<Pending>")]
		public override int GetHashCode()
		{
			//Found at: https://www.loganfranken.com/blog/692/overriding-equals-in-c-part-2/
			unchecked
			{
				// Choose large primes to avoid hashing collisions
				const int HashingBase = (int)2166136261;
				const int HashingMultiplier = 16777619;

				int hash = HashingBase;
				hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, X) ? X.GetHashCode() : 0);
				hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Y) ? Y.GetHashCode() : 0);
				hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, IsOrigin) ? IsOrigin.GetHashCode() : 0);
				return hash;
			}
		}
	}
}
