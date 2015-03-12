using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeClass someClass = new SomeClass();
			try
			{
				someClass.SomeTask();
			}
			catch (InvalidOperationException)
			{
				//Handle as per need
			}

			someClass.IsLogMode = true;
			someClass.SomeTask();
		}
	}

	class SomeClass
	{
		private bool isLogMode = false;

		public bool IsLogMode
		{
			get { return isLogMode; }
			set { isLogMode = value; }
		}

		public void SomeTask()
		{
			try
			{
				//Do Something
				//Exception occured
				throw new InvalidOperationException();
			}
			catch (InvalidOperationException) when (isLogMode)
			{
				//Log that error
			}
		}
	}
}
