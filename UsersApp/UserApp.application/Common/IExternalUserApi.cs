using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.DTOs.Users;

namespace UserApp.application.Common
{
    public interface IExternalUserApi
    {
        Task<IEnumerable<ExternalUserDto>> GetUsersAsync();
    }
}
