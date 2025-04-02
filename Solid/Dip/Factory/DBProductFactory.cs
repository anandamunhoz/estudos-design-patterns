using System.Configuration;
using Dip.Model;
using Dip.Model.Interface;

namespace Dip.Factory
{
     class DBProductFactory
    {
        public static IDBProduct Create() 
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }          
            else 
            {
                return new MongoDBProduct();
            }
        }
    }
}
