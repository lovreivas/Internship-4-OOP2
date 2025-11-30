using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;

namespace UserApp.application.Common
{
    public interface IUserCacheService
    {
        Task<IEnumerable<User>> GetUsersFromCacheOrApiAsync();
    }
}
