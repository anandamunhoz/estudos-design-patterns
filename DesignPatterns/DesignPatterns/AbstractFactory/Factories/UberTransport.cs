using AbstractFactory.Aircrafts;
using AbstractFactory.Factories.Interface;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle()
        {
           return new Car();
        }
    }
}
