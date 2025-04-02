using Dip.Model.Interface;

namespace Dip.Model
{
     class MongoDBProduct : IDBProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}. ";
        }
    }
}
