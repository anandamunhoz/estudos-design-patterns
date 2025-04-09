using System;

namespace Adapter
{
     class Program
     {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();

            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //Console.ReadLine();

            //Payonner payment = new Payonner();

            //payment.SendPayment();
            //payment.ReceivePayment();

            //Console.ReadLine();

            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());

            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago.MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();
            
            Console.ReadLine();

        }
     }
}
