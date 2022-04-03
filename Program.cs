//driver code
using System;
using System.IO;

namespace FindAFileInDirectory_Recursion{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			s.solve(args[0], args[1]);
		}
	}
}
