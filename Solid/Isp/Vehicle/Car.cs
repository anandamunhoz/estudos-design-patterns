using System;
using Isp.Vehicle.Interface;

namespace Isp.Vehicle
{
    class Car : IVehicleCar
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Criando um carro com a cor {color}, ano {year}, motor {engine}, {seats} assentos e {doors} portas");

            StartVehicle();
        }
      
        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores do Carro!");
        }
    }
}
