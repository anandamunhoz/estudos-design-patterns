using System;
using AbstractFactory.App;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Interface;

namespace AbstractFactory
{
     class Program
     {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;

            string company = "Lime";

            switch (company)
            {
                case "Uber":
                    transportFactory = new UberTransport();
                    break;
                case "99":
                    transportFactory = new NineNineTransport();
                    break;
                case "Lime":
                    transportFactory = new LimeTransport();
                    break;
                default:
                    transportFactory = new NineNineTransport();
                    break;
            }

            app = new Application(transportFactory);

            return app;
        }
         static void Main(string[] args)
         {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
         }
     }
}
