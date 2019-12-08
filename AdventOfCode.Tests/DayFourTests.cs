using com.nerdlyhaxor.AdventOfCode.Logic.Day04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Tests
{
	[TestClass]
	public class DayFourTests
	{
		[TestMethod]
		public void ContainsDuplicates()
		{
			Assert.IsTrue(PasswordValidator.ContainsDuplicates("111111"));
		}

		[TestMethod]
		public void NeverDescreases()
		{
			Assert.IsTrue(!PasswordValidator.NeverDecreases("223450"));
			Assert.IsTrue(PasswordValidator.NeverDecreases("223456"));
		}

		[TestMethod]
		public void NoDoubles()
		{
			Assert.IsTrue(!PasswordValidator.ContainsDuplicates("123789"));
		}

		[TestMethod]
		public void ValidatesThreePassword()
		{
			var passwords = new List<string>()
			{
				"111111", //Good Password
				"223450", //Bad Password
				"223456", //Good Password
				"123789", //Bad Password
				"123788", //Good Password
			};

			var numberOfGoodPasswords = 0;

			passwords.ForEach(password => numberOfGoodPasswords += PasswordValidator.IsValidPassword(password) ? 1 : 0);

			Assert.AreEqual(3, numberOfGoodPasswords);
		}
	}
}
