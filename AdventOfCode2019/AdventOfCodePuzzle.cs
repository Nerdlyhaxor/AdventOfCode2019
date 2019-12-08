using com.nerdlyhaxor.AdventOfCode.Logic.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode
{
	public class AdventOfCodePuzzle
	{
		public int Day { get; set; }

		public int Part { get; set; }

		public string FileName
		{
			get { return $"input-{this.Day}-{this.Part}.txt"; }
		}
		public AdventOfCodeSolver Solver { get; set; }
	}
}
