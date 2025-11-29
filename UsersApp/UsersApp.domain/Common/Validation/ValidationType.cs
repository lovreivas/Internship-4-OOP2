using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Validation
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ValidationType
    {
        FormalValidation,
        BusinessRule,
        SystemError
    }
}
