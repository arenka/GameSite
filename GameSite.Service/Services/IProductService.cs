using System.Collections.Generic;
using GameSite.Data.Entity;

namespace GameSite.Service.Services
{
    public interface IProductService
    {
        void Insert(Product product);
        Product GetById(int parse);
        void Update(Product product);
        List<Product> GetAll();
        void Delete(Product product);
      
    }
}
