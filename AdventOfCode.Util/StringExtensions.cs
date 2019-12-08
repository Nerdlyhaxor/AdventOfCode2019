using System;
using System.Collections.Generic;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Util
{
	public static class StringExtensions
	{
		public static int ToInt(this string value) =>
			Int32.TryParse(value, out _) ?
				Int32.Parse(value) : 0;
	}
}
