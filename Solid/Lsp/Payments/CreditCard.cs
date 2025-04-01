using System;

namespace Lsp.Payments
{
     class CreditCard : NubankCard
     {
        public override void Validate()
        {
           Console.WriteLine("Validação do limite do cartão de crédito");
           Console.WriteLine("Ok");
        }
    }
}
