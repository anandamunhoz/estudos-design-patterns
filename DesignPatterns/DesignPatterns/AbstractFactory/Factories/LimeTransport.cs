﻿using AbstractFactory.Aircrafts;
using AbstractFactory.Factories.Interface;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
