using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.application.Common.Model
{
    public class SuccessResponse
    {
        public bool IsSuccess { get; init; }
        public SuccessResponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public SuccessResponse()
        {
        }
    }
}
