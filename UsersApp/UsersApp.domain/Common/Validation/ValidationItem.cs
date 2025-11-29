using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UsersApp.domain.Common.Validation
{
    public class ValidationItem
    {
        public ValidationSeverity ValidationSeverity { get; set; }
        public ValidationType ValidationType { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
