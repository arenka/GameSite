using System.Collections.Generic;
using System.Linq;
using GameSite.Data.Entity;
using GameSite.Data.Repositories;

namespace GameSite.Service.Services.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll().ToList();
        }
    }
}
