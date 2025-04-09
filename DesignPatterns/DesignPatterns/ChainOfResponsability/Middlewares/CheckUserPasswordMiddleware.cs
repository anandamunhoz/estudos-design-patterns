using System;

namespace ChainOfResponsability.Middlewares
{
     class CheckUserPasswordMiddleware : Middleware
     {    

        public override bool Check(string email, string password)
        {
         
            if( password == "123456") 
            {
                Console.WriteLine("Senha fraca, altere-a para uma senha segura.");
            }

            return CheckNext(email, password);

        }
    
     }
}
