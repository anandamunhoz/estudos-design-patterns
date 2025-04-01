using System;
using Isp.Vehicle.Interface;

namespace Isp.Vehicle
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }      

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
           this.color = color;
           this.year = year;
           this.engine = engine;

            Console.WriteLine($"Criando uma moto com a cor {color}, ano {year}, motor {engine} cilindradas.");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores da Moto!");
        }
    }
}
