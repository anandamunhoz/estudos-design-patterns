using System;
using Dip.Factory;
using Dip.Model.Interface;

namespace Dip.Payments
{
     class PaymentProcess
    {
        public void Pay(string id) 
        {
            IDBProduct product = DBProductFactory.Create();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
