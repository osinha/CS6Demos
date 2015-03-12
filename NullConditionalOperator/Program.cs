using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			p.FirstName = "Bruce";
			p.LastName = "Wayne";

			//Passing valid instance
			Console.WriteLine(GetFirstName(p));
			Console.WriteLine(GetFirstNameCS6(p));

			//Passing Null
			Console.WriteLine(GetFirstName(null));
			Console.WriteLine(GetFirstNameCS6(null));
			Console.ReadKey();
		}

		private static string GetFirstName(Person p)
		{
			string result = null;

			//Prior to C#6 we need to null check
			if (p != null)
			{
				result = p.FirstName;
			}

			return result;
		}

		private static string GetFirstNameCS6(Person p)
		{
			string result = null;

			//Using NullConditional Operator
			result = p?.FirstName;

			return result;
		}
	}

	class Person
	{
		private string firstName = null;
		private string lastName = null;

		event EventHandler<string> OnFirstNameChanged;
		event EventHandler<string> OnLastNameChanged;

		public string FirstName
		{
			get
			{
				return firstName;
			}

			set
			{
				firstName = value;
				//Using Null check for checking subscribers prior to C#6
				if (this.OnFirstNameChanged != null)
				{
					this.OnFirstNameChanged.Invoke(this, value);
				}
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}

			set
			{
				lastName = value;
				//Using NullConditional Operator
				this.OnLastNameChanged?.Invoke(this, value);
			}
		}
	}
}
