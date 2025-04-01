using System;

namespace Lsp.Payments
{
     class DebitCard : NubankCard
     {
        public override void Validate()
        {
            Console.WriteLine("Verificação do saldo da conta ");
            Console.WriteLine("Saldo disponível");
        }
    }
}
