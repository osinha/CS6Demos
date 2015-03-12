using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropInitializer
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			Console.WriteLine($"Hello ! {p.FirstName} {p.LastName}");
			Console.ReadKey();
		}
	}

	class Person
	{
		//Setting default property to get/set property
		public string FirstName { get; set; } = "Default";
		public string LastName { get; set; } = "Name";
		//Setting default property to getter only property
		public string SomePropertya { get; } = "ReadonlyProp";
	}
}
