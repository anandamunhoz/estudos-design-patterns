namespace Adapter.Interfaces
{
     interface IPayonnerPayment
     {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
     }
}
