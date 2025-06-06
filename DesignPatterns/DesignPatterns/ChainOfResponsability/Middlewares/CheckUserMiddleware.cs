﻿using System;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email)) 
            {
                Console.WriteLine("Email inválido");
                return false;
            }

            if (!server.IsValidPassword(email, password)) 
            {
                Console.WriteLine("E-mail e/ou Senha inválidos!");
                return false;
            }
           
               return CheckNext(email, password);           
        }
    }
}
