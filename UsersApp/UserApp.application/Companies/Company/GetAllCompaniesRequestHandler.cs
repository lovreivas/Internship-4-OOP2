using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common.Model;
using UserApp.application.DTOs.Companies;
using UsersApp.domain.Persistence.Companies;

namespace UserApp.application.Companies.Company
{
    public class GetAllCompaniesRequest { }
    public class GetAllCompaniesRequestHandler : RequestHandler<GetAllCompaniesRequest, List<CompanyDto>>
    {
        private readonly ICompanyUnitOfWork _unitOfWork;
        private string _userUsername;
        private string _userPassword;
        public void SetUserData(string username, string password)
        {
            _userUsername = username;
            _userPassword = password;
        }
        public GetAllCompaniesRequestHandler(ICompanyUnitOfWork companyUnitOfWork)
        {
            _unitOfWork = companyUnitOfWork;
        }
        protected async override Task<Result<List<CompanyDto>>> HandleRequest(GetAllCompaniesRequest request, Result<List<CompanyDto>> result)
        {

            var company = await _unitOfWork.Repository.Get();


            var dto = company.Values
                .Select(CompanyDto.FromEntity)
                .ToList();

            result.SetResult(dto);
            return result;
        }

        protected override Task<bool> IsActive()
        {
            return Task.FromResult(true);
        }
    }
}
