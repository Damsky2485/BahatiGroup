using BahatiGroup.Web.Shared.Core.Interfaces;
using BahatiGroup.Web.Shared.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BahatiGroup.Web.Shared.Core.Repositories
{ 
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(BahatiDbContext _demoDbContext): base(_demoDbContext)
        {

        }

        public async Task<Company> AddompanyAsync(Company company)
        {
            try
            {
                var result = await demoDbContext.Companies.AddAsync(company);
                await demoDbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void DeleteCompany(int companyId)
        {
            var result = await demoDbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == companyId);

            if(result !=null)
            {
                demoDbContext.Companies.Remove(result);
                await demoDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Company>> GetCompaniesAsync()
        {
           var companies = await demoDbContext.Companies
                .Include(c => c.Addresses)
                .ToListAsync<Company>();
            return companies;
        }

        public async Task<Company> GetCompanyById(int companyId)
        {
            try
            {
                return await demoDbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == companyId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Company> UpdateCompanyAsync(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
