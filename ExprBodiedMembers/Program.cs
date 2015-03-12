using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExprBodiedMembers
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			p.FirstName = "Bruce";
			p.LastName = "Wayne";

			Console.WriteLine(p.Name);
			Console.WriteLine(p.GetSomething());
			Console.ReadKey();
		}
	}

	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		//Using Expression for the property
		public string Name => FirstName + " " + LastName;

		//Using Expression for method
		public string GetSomething() => "Something";
	}
}
