using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);

        Task<Company> GetCompanyAsync(int companyId, bool trackChanges);

        void CreateCompany(Company company);

        Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<int> ids, bool trackChanges);

        void DeleteCompany(Company company);
    }
}
