using System;
using Bridge.Platforms;

namespace Bridge.Transmissions.Interfaces
{
    class Live : ITransmission
    {
        protected IPlatform platform;
        public Live(IPlatform platform)
        {
            this.platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {platform}");
        }

        public void Result()
        {
            Console.WriteLine("***** ON Air *****\n");
        }
    }
}
