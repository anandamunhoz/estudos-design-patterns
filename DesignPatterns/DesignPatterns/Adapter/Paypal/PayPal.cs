﻿using System;

namespace Adapter
{
    class PayPal : IPayPalPayment
    {
        private Token token;
        
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Paypal");
        }

        public void PayPalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Paypal");
        }
    }
}
