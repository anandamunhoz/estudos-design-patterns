namespace Isp.Vehicle.Interface
{
     interface IVehicleCar : IVehicle
     {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
     }
}
