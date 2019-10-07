using System.Collections.Generic;
using GameSite.Data.Entity;

namespace GameSite.Service.Services
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        void Update(Company company);
        void Delete(Company company);
        void Insert(Company company);
        Company GetById(int parse);
    }
}
