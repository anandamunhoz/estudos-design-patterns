using System;
using Bridge.Platforms;
using Bridge.Transmissions;
using Bridge.Transmissions.Interfaces;

namespace Bridge
{    
     class Program
     {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);
            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();           
            live.Comments();
            live.Subtitle();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLiveAdvanced(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        }
     }
}
