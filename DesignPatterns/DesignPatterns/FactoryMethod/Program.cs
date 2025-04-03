using System;
using FactoryMethod.Factories;

namespace FactoryMethod
{
     class Program
     {
        static void Main(string[] args)
        {
            Transport transport = null;

            switch (args.Length > 0 ? args[0] : null)
            {
                case "--uber":
                    transport = new CarTransport();
                    break;
                case "--log":
                    transport = new MotorcycleTransport();
                    break;
                case "--uberEats":
                    transport = new BicycleTransport();
                    break;
                default:
                    Console.WriteLine("Selecione o tipo do serviço.");
                    break;
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
     }
}
