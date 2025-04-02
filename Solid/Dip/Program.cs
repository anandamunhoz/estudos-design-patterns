using System;

namespace Dip
{
     class Program
     {
        static void Main(string[] args)
        {

            Payments.PaymentProcess payment = new Payments.PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
     }
}
