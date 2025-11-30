using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Persistence.Common;

namespace UsersApp.domain.Persistence.Companies
{
    public interface ICompanyUnitOfWork : IUnitOfWork
    {
        ICompanyRepository Repository { get; }
    }
}
