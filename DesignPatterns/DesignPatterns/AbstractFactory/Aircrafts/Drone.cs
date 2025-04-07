using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga à bordo, voo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
