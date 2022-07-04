using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
	

		public string Year { get; set; } = "2012";
		public string Make { get; set; } = "Toyota";
		public string Model { get; set; } = "RAV4";

		//abstract method
		public abstract void DriveAbstract(); //stubbed out method

		//virtual method
		public virtual void DriveVirtual()
        {
			Console.WriteLine($"I like to drive my {GetType().Name} virtually");
        }

		
		
	}
}

