using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }
		public string Color { get; set; }
		public string Engine { get; set; }
		public bool IsElectric { get; set; }
	}
}

