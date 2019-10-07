using System.Collections.Generic;
using GameSite.Data.Entity;

namespace GameSite.Service.Services
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
