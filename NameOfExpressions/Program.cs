using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfExpressions
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();

			//Checking nameof from instance - Will return "FirstName"
			Console.WriteLine(nameof(p.FirstName));

			//Checking nameof from Type - Will return "FirstName"
			Console.WriteLine(nameof(Person.FirstName));
			Console.ReadKey();
		}
	}

	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class MainViewModel : BindableBase
	{
		#region Attributes
		private string someValue;
		private string someText;
		#endregion

		#region Properties

		public string SomeValue
		{
			get
			{
				return someValue;
			}

			set
			{
				someValue = value;
				//Literal string used Prior to C#6(prone to errors)
				OnPropertyChanged("SomeValue");

				//Or Using property expression(Not so readable)
				OnPropertyChanged(() => this.SomeValue);
			}
		}

		public string SomeText
		{
			get
			{
				return someText;
			}
			set
			{
				someText = value;

				//Using nameof to provide the PropertyName
				OnPropertyChanged(nameof(SomeText));
			}
		}

		#endregion
	}
}
