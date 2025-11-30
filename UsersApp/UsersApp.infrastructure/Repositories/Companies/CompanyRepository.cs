using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;
using UsersApp.domain.Persistence.Companies;
using UsersApp.infrastructure.Dapper;
using UsersApp.infrastructure.Database;
using UsersApp.infrastructure.Repositories.Common;

namespace UsersApp.infrastructure.Repositories.Companies
{
    public class CompanyRepository : Repository<Company, int>, ICompanyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IDapperManager _dapperManager;
        public CompanyRepository(DbContext dbContext, IDapperManager dapperManager) : base(dbContext)
        {
            _dapperManager = dapperManager;
        }

        public async Task<Company> GetById(int id)
        {
            var sql = "SELECT id as ID, name as Name FROM public.Users WHERE Id = @Id";
            var parameters = new { Id = id };
            return await _dapperManager.QuerySingleAsync<Company>(sql, parameters);
        }
    }
}
