using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

		public override void DriveAbstract()
        {
			Console.WriteLine($"This {GetType().Name} is driving abstractly");
			
        }

		public bool HasTrunk { get; set; }

	}
}

