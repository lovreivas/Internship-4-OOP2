using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Abstractions;
using UsersApp.domain.Common.Validation.ValidationItems;

namespace UsersApp.domain.Entities
{
    public class Company 
    {
        public const int NameMaxLength = 150;
        public string Name { get; set; }

        public async Task<Result<bool>> Create(ICompanyRepository companyRepository)
        {
            var validationResult = await CreateOrUpdateValidation();
            if (validationResult.HasError)
            {
                return new Result<bool>(false, validationResult);
            }

            await companyRepository.InsertAsync(this);

            return new Result<bool>(true, validationResult);


        }
        public async Task<Common.Validation.ValidationResult> CreateOrUpdateValidation()
        {
            var validationResult = new Common.Validation.ValidationResult();
            if (Name?.Length > NameMaxLength)
            {
                validationResult.AddValidationItem(CompanyValidationItems.Company.NameMaxLength);
            }


            return validationResult;
        }
    }
}
