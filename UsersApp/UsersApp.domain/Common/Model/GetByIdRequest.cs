using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Model
{
    public class GetByIdRequest
    {
        public int Id { get; init; }
        public GetByIdRequest(int id)
        {
            Id = id;
        }
        public GetByIdRequest()
        {
        }
    }
    public class GetByIdRequest<TId>
    {
        public TId Id { get; init; }
        public GetByIdRequest(TId id)
        {
            Id = id;
        }
        public GetByIdRequest()
        {
        }
    }
}
