using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common.Model;
using UsersApp.domain.Persistence.Companies;

namespace UserApp.application.Companies.Company
{
    public class CreateCompanyRequest
    {
        public string Name { get; set; }


    }
    public class CreateCompanyRequestHandler : RequestHandler<CreateCompanyRequest, SuccessPostResponse>
    {
        private readonly ICompanyUnitOfWork _unitOfWork;
        public CreateCompanyRequestHandler(ICompanyUnitOfWork companyUnitOfWork)
        {
            _unitOfWork = companyUnitOfWork;
        }
        protected async override Task<Result<SuccessPostResponse>> HandleRequest(CreateCompanyRequest request, Result<SuccessPostResponse> result)
        {
            var company = new UsersApp.domain.Entities.Company
            {
                Name = request.Name
            };
            var validationResult = await company.Create(unitOfWork.Repository);
            result.SetValidationResult(validationResult.ValidationResult);
            if (result.HasError)
                return result;
            await _unitOfWork.SaveAsync();
            result.SetResult(new SuccessPostResponse(company.Id));
            return result;
        }

        protected override Task<bool> IsActive()
        {
            return Task.FromResult(true);
        }
    }
}
