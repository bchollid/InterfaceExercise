using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var prius = new Car()
            {
                Color = "Red",
                CompanyName = "Toyota",
                Engine = "4-cylinder",
                HasTrunk = true,
                IsAutomatic = true,
                IsElectric = true,
                NumberOfWheels = 4,
                Logo = "T"
            };

            var f150 = new Truck()
            {
                Color = "Blue",
                CompanyName = "Ford",
                Engine = "8-cylinder",
                IsLifted = true,
                HasBackseats = true,
                IsElectric = false,
                NumberOfWheels = 4,
                Logo = "F"
            };

            var grandCherokee = new SUV()
            {
                Color = "Grey",
                CompanyName = "Jeep",
                Engine = "6-cylinder",
                CanTow = true,
                NumberOfSeats = 4,
                IsElectric = false,
                NumberOfWheels = 4,
                Logo = "Jeep"
            };

            Console.WriteLine("Car information below:");
            Console.WriteLine($"This {prius.Color} Prius is made by {prius.CompanyName}. The company's logo is in the shape of a {prius.Logo}. The engine is a {prius.Engine} and it has {prius.NumberOfWheels} wheels. Is it electric? {prius.IsElectric}. Is it automatic? {prius.IsAutomatic}. It is {prius.HasTrunk} that it has a trunk.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Truck information below:");
            Console.WriteLine($"This {f150.Color} F150 is made by {f150.CompanyName}. The company's logo is in the shape of a {f150.Logo}. The engine is a {f150.Engine} and it has {f150.NumberOfWheels} wheels. Is it electric? {f150.IsElectric}. Does it have backseats? {f150.HasBackseats}. It is {f150.IsLifted} that this truck is lifted");
            Console.WriteLine("------------------------------");
            Console.WriteLine("SUV information below:");
            Console.WriteLine($"This {grandCherokee.Color} Grand Cherokee is made by {grandCherokee.CompanyName}. The company's logo is in the shape of a {grandCherokee.Logo}. The engine is a {grandCherokee.Engine} and it has {grandCherokee.NumberOfWheels} wheels. Is it electric? {grandCherokee.IsElectric}. Can it tow? {grandCherokee.CanTow}. It has {grandCherokee.NumberOfSeats} seats.");
            Console.WriteLine("------------------------------");

            //Creatively display and organize their values
        }
    }
}
