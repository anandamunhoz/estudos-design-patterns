using System;
using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
           
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Vehicle Type: {sedan.VehicleType}");
            Console.WriteLine($"Engine: {sedan.Engine} ");
            Console.WriteLine($"Seats: {sedan.Seats}");
            Console.WriteLine($"Transmission: {sedan.Transmission}\n");

            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Vehicle Type: {truck.VehicleType}");
            Console.WriteLine($"Engine: {truck.Engine} ");
            Console.WriteLine($"Seats: {truck.Seats}");
            Console.WriteLine($"Transmission: {truck.Transmission}\n");        

            director.ConstructSUV();

            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Vehicle Type: {suv.VehicleType}");
            Console.WriteLine($"Engine: {suv.Engine} ");
            Console.WriteLine($"Transmission: {suv.Transmission}");
            Console.WriteLine($"HasAirbag: {suv.HasAirbag}");

            Console.ReadLine();
        }

    }
}
