using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			p.FirstName = "Bruce";
			p.LastName = "Wayne";

			//Using string format (Difficult to read and Error prone)
			string result = string.Format("Hello ! {0} {1}", p.FirstName, p.LastName);
			//Console.WriteLine(result);

			//Using StringInterpolation in C#6 prints 
			result = $"Hello ! {p.FirstName} {p.LastName}";
			Console.WriteLine(result);
			Console.ReadKey();
        }
	}

	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
