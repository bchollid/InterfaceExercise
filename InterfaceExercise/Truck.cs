using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}
        public bool HasBackseats { get; set; }
        public bool IsLifted { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public bool IsElectric { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}

