using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

        public int NumberOfSeats { get; set; }
        public bool CanTow { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public bool IsElectric { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}

