using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BahatiGroup.Web.Shared.Core.Interfaces
{
   public interface ICompanyRepository
    {
        Task<Company> AddompanyAsync(Company company);
        Task<List<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyById(int companyId);
        Task<Company> UpdateCompanyAsync(Company company);
        void DeleteCompany(int companyId);
    }
}
