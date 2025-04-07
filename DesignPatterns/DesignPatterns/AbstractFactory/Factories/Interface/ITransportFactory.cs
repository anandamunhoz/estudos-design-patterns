using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories.Interface
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();


    }
}
