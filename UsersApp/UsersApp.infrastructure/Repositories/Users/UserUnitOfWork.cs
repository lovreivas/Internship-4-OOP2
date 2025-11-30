using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Persistence.Users;
using UsersApp.infrastructure.Database;

namespace UsersApp.infrastructure.Repositories.Users
{
    public class UserUnitOfWork : IUserUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IUserRepository Repository { get; set; }
        public UserUnitOfWork(ApplicationDbContext dbContext, IUserRepository userRepository)
        {
            _dbContext = dbContext;
            Repository = userRepository;
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
