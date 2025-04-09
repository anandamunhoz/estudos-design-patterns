using System;

namespace Bridge.Platforms
{
     class Facebook : IPlatform
     {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando a aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando RMTP");
        }
    }
}
