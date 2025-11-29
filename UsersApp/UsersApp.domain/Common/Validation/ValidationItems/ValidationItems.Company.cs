using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Validation.ValidationItems
{
    public static class CompanyValidationItems
    {
        public static class Company
        {
            public static string CodePrefix = nameof(Company);

            public static readonly ValidationItem NameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}_1",
                Message = $"Naziv prelazi maksimalnu dopuštenu duljinu ({Entities.Company.NameMaxLength}).",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem NameUnique = new ValidationItem
            {
                Code = $"{CodePrefix}_2",
                Message = $"Naziv mora biti jedinstven.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };
        }
    }

}
