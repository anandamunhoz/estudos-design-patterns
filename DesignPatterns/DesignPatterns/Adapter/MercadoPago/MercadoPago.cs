using System;

namespace Adapter.MercadoPago
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }

        public void SendPaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }
    }
}
