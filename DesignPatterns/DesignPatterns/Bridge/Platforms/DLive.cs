using System;

namespace Bridge.Platforms
{
    class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissão Iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando a aplicação");
        }

        public void ConfigureRMTP()
        {
          Console.WriteLine("DLive: Configurando RMTP");
        }
    }
}
