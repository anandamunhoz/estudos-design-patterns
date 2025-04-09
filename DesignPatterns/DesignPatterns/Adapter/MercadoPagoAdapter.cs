using System;
using Adapter.MercadoPago;

namespace Adapter
{
     class MercadoPagoAdapter : IPayPalPayment
     {
        private MercadoPago.MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago.MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando a adaptação de Mercado Pago para os métodos de Paypal");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.SendPaymentMercadoPago();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.ReceivePaymentMercadoPago();
        }
    }
}
