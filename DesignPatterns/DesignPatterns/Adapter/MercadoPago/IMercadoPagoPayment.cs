namespace Adapter.MercadoPago
{
     interface IMercadoPagoPayment
     {
        Token AuthToken();
        void SendPaymentMercadoPago();
        void ReceivePaymentMercadoPago();
     }     
}
