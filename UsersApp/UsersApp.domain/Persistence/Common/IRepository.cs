using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Common.Model;

namespace UsersApp.domain.Persistence.Common
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        Task<GetAllResponse<TEntity>> Get();
        Task InsertAsync(TEntity entity);
        void Update(TEntity entity);
        Task DeleteAsync(TId id);
        void Delete(TEntity? entity);



    }
}
