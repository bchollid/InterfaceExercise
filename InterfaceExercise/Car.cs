using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}

		public bool HasTrunk { get; set; }
		public bool IsAutomatic { get; set; }
		public int NumberOfWheels { get; set; }
        public string Color { get; set; }
		public string Engine { get; set; }
		public bool IsElectric { get; set; }
		public string Logo { get; set; }
		public string CompanyName { get; set; }
    }
}

