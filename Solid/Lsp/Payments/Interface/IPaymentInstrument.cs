namespace Lsp.Payments.Interface
{
     interface IPaymentInstrument
     {
        void Validate();
        void CollectPayment();
     }
}
