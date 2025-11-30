using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;
using UsersApp.domain.Persistence.Common;

namespace UsersApp.domain.Persistence.Users
{
    public interface IUserRepository : IRepository<User, int>
    {
        Task<User> GetById(int id);
    }
}
