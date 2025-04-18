﻿using System;
using Bridge.Platforms;
using Bridge.Transmissions.Interfaces;

namespace Bridge.Transmissions
{
     class AdvancedLive : Live
     {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
            
        } 

        public void Subtitle() 
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments() 
        {
            Console.WriteLine("Comentários liberados na live!");
        }

        public void Record()
        {
            Console.WriteLine("Gravando a transmissão!");
        }
    }
}
