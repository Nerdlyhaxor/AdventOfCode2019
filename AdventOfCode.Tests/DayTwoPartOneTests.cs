using System;
using System.Collections.Generic;
using System.Text;
using com.nerdlyhaxor.AdventOfCode.Logic;
using com.nerdlyhaxor.AdventOfCode.Logic.Day02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
	[TestClass]
	public class DayTwoPartOneTests
	{
		[TestMethod]
		public void DayTwoPartOneTestExampleOne()
		{
			var problem = new DayTwoPartOne("1,0,0,0,99");
			Assert.AreEqual(2, problem.Solve()[0]);
		}

		[TestMethod]
		public void DayTwoPartOneTestExampleTwo()
		{
			var problem = new DayTwoPartOne("2,3,0,3,99");
			Assert.AreEqual(6, problem.Solve()[3]);
		}

		[TestMethod]
		public void DayTwoPartOneTestExampleThree()
		{
			var problem = new DayTwoPartOne("2,4,4,5,99,0");
			Assert.AreEqual(9801, problem.Solve()[5]);
		}

		[TestMethod]
		public void DayTwoPartOneTestExampleFour()
		{
			var problem = new DayTwoPartOne("1,1,1,4,99,5,6,0,99");
			var results = problem.Solve();
			Assert.AreEqual(30, results[0]);
			Assert.AreEqual(2, results[4]);
		}
	}
}