using AbstractFactory.Aircrafts;
using AbstractFactory.Factories.Interface;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    internal class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
