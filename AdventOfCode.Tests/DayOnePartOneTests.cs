using System;
using System.Collections.Generic;
using System.Text;
using com.nerdlyhaxor.AdventOfCode.Logic;
using com.nerdlyhaxor.AdventOfCode.Logic.Day01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
	[TestClass]
	public class DayOnePartOneTests
	{
		[TestMethod]
		public void DayOnePartOneExampleOne()
		{
			var listValues = new List<int>(new int[] { 12 });

			var problem = new DayOnePartOne(listValues);

			Assert.IsTrue(problem.Solve() == 2);
		}

		[TestMethod]
		public void DayOnePartOneExampleTwo()
		{
			var listValues = new List<int>(new int[] { 14 });

			var problem = new DayOnePartOne(listValues);

			Assert.IsTrue(problem.Solve() == 2);
		}

		[TestMethod]
		public void DayOnePartOneExampleThree()
		{
			var listValues = new List<int>(new int[] { 1969 });

			var problem = new DayOnePartOne(listValues);

			Assert.IsTrue(problem.Solve() == 654);
		}

		[TestMethod]
		public void DayOnePartOneExampleFour()
		{
			var listValues = new List<int>(new int[] { 100756 });

			var problem = new DayOnePartOne(listValues);

			Assert.IsTrue(problem.Solve() == 33583);
		}
	}
}
