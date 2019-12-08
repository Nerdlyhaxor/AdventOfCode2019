using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace com.nerdlyhaxor.AdventOfCode.Util
{
	public static class FileHelper
	{
		public static List<string> GetFileContent(string fileName)
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);

			using (var reader = new StreamReader(path))
			{
				return reader
					.ReadToEnd()
					.Split(Environment.NewLine.ToCharArray())
					.ToList();
			}
		}
	}
}
