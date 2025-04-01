using System;
using Lsp.Payments;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreditCard creditCard = new CreditCard();

            //creditCard.Validate();
            //creditCard.CollectPayment();

            //Console.ReadLine();

            //DebitCard debitCard = new DebitCard();

            //debitCard.Validate();
            //debitCard.CollectPayment();

            //Console.ReadLine();

            NubankRewards nubankRewards = new NubankRewards();
            
            nubankRewards.Validate();
            nubankRewards.CollectPayment();
            
            Console.ReadLine();

        }
    }
}
