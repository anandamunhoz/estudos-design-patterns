using Dip.Model.Interface;

namespace Dip.Model
{
     class SQLServerProduct : IDBProduct
    {

        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}. ";
        }


     }
}
