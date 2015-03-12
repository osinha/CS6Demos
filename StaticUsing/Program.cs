using System;
//Adding static using for Console class
using static System.Console;

namespace StaticUsing
{
	class Program
	{
		static void Main(string[] args)
		{
			//Using Full Qualified name
			Console.WriteLine("Hello");

			//Using function name directly
			WriteLine("Hello Again");

			ReadKey();
		}
	}
}
