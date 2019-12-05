using com.nerdlyhaxor.AdventOfCode.Logic.Day03;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Tests
{
	[TestClass]
	public class DayThreeTests
	{
		[TestMethod]
		public void NewWireAtOrigin()
		{
			var wire = new Wire();

			var actualPoint = wire.GetCurrentLocation();
			var expectedPoint = new Point() { X = 0, Y = 0 };

			Assert.AreEqual(expectedPoint, actualPoint);
		}

		[TestMethod]
		public void MoveWire()
		{
			var wire = new Wire();

			var movePointUp = wire.Move(Direction.Up, 1);
			var movePointDown = wire.Move(Direction.Down, 1);
			var movePointRight = wire.Move(Direction.Right, 1);
			var movePointLeft = wire.Move(Direction.Left, 1);

			Assert.AreEqual(new Point() { X = 0, Y = 1 }, movePointUp);
			Assert.AreEqual(new Point() { X = 0, Y = -1 }, movePointDown);
			Assert.AreEqual(new Point() { X = -1, Y = 0 }, movePointLeft);
			Assert.AreEqual(new Point() { X = 1, Y = 0 }, movePointRight);
		}

		[TestMethod]
		public void ParseDirection()
		{
			Assert.AreEqual(Direction.Up, NavInstruction.ParseDirection("U"));
			Assert.AreEqual(Direction.Down, NavInstruction.ParseDirection("D"));
			Assert.AreEqual(Direction.Left, NavInstruction.ParseDirection("L"));
			Assert.AreEqual(Direction.Right, NavInstruction.ParseDirection("R"));
		}

		[TestMethod]
		public void ParseNavEntry()
		{
			var instructionOne = NavInstruction.ParseEntry("U1");
			var instructionTwo = NavInstruction.ParseEntry("D12");
			var instructionThree = NavInstruction.ParseEntry("R123");
			var instructionFour = NavInstruction.ParseEntry("L1234");

			Assert.AreEqual(new NavInstruction() { NavDirection = Direction.Up, Number = 1 }, instructionOne);
			Assert.AreEqual(new NavInstruction() { NavDirection = Direction.Down, Number = 12 }, instructionTwo);
			Assert.AreEqual(new NavInstruction() { NavDirection = Direction.Right, Number = 123}, instructionThree);
			Assert.AreEqual(new NavInstruction() { NavDirection = Direction.Left, Number = 1234 }, instructionFour);
		}

		[TestMethod]
		public void ParseString()
		{
			const string navString = "R123,U123";

			var navInstructions = new[]
			{
				new NavInstruction { NavDirection = Direction.Right, Number = 123 },
				new NavInstruction { NavDirection = Direction.Up, Number = 123 }
			};

			var actualInstructions = NavInstruction.ParseString(navString);

			for (var i = 0; i < navInstructions.Length; i++)
				Assert.AreEqual(navInstructions[i], actualInstructions[i]);
		}

		[TestMethod]
		public void Navigate()
		{
			const string navString = "R1,U1";

			var expectedWire = new Wire();

			expectedWire.Locations.Add(new Point() { X = 1, Y = 0 });
			expectedWire.Locations.Add(new Point() { X = 1, Y = 1 });

			var actualWire = new Wire();
			actualWire = actualWire.Navigate(navString);

			Assert.AreEqual(expectedWire, actualWire);
		}

		[TestMethod]
		public void IntersectionTest()
		{
			var wire1 = new Wire();

			wire1 = wire1.Navigate("L1,U1,R1");

			var wire2 = new Wire();

			wire2 = wire2.Navigate("R1,U1,L1");

			var grid = new Grid();

			grid.Wires.Add(wire1);
			grid.Wires.Add(wire2);

			var intersections = grid.FindIntersections();

			Assert.IsTrue(intersections.Count == 1);

			Assert.AreEqual(new Point() { X = 0, Y = 1 }, intersections[0]);
		}
	}
}
