using System;
using Lsp.Payments.Interface;

namespace Lsp.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
            //Validação básica 
        }
    }
}
