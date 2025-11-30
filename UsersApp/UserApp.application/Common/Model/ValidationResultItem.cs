using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Common.Validation;

namespace UserApp.application.Common.Model
{
    public class ValidationResultItem
    {
        public ValidationSeverity ValidationSeverity { get; set; }
        
        public ValidationType ValidationType { get; init; }

        public string Code { get; set; }
        public string Message { get; set; }

        public static ValidationResultItem FormValidationItem(ValidationResultItem item)
        {
            return new ValidationResultItem
            {
                ValidationSeverity = item.ValidationSeverity,
                ValidationType = item.ValidationType,
                Code = item.Code,
                Message = item.Message
            };
        }
    }
}
