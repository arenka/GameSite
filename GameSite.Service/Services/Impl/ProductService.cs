using System.Collections.Generic;
using System.Linq;
using GameSite.Data.Entity;
using GameSite.Data.Repositories;

namespace GameSite.Service.Services.Impl
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void Insert(Product product)
        {
            _repository.Insert(product);
        }

        public Product GetById(int parse)
        {
          return  _repository.GetBy(product => product.Id == parse);
        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public void Delete(Product product)
        {
            _repository.Delete(product);
        }

    
    }
}
