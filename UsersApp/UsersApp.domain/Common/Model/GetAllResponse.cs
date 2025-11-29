using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Model
{
    public class GetAllResponse<TValue>
    {
        public IEnumerable<TValue> Values { get; init; }
    }
}
