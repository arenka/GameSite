using System.Collections.Generic;
using System.Linq;
using GameSite.Data.Entity;
using GameSite.Data.Repositories;

namespace GameSite.Service.Services.Impl
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _companyRepository;

        public CompanyService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void Delete(Company company)
        {
            _companyRepository.Delete(company);
        }

        public List<Company> GetAll()
        {
            return _companyRepository.GetAll().ToList();
        }

        public Company GetById(int parse)
        {
            return _companyRepository.GetBy(_ => _.Id == parse);
        }

        public void Insert(Company company)
        {
            _companyRepository.Insert(company);
        }

        public void Update(Company company)
        {
            _companyRepository.Update(company);
        }
    }
}
