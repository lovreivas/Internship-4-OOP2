using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.application.Common.Model
{
    public class SuccessPostResponse
    {
        public int? Id { get; init; }
        public SuccessPostResponse(int? id)
        {
            Id = id;
        }
        public SuccessPostResponse()
        {
        }
    }
}
