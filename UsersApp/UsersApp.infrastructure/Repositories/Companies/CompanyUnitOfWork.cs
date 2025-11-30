using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Persistence.Companies;
using UsersApp.infrastructure.Database;

namespace UsersApp.infrastructure.Repositories.Companies
{
    public class CompanyUnitOfWork : ICompanyUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public ICompanyRepository Repository { get; set; }

        public CompanyUnitOfWork(ApplicationDbContext dbContext, ICompanyRepository companyRepository)
        {
            _dbContext = dbContext;
            Repository = companyRepository;
        }
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
