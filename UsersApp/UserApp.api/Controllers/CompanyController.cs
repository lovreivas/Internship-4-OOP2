using Microsoft.AspNetCore.Mvc;
using UserApp.api.Common;
using UserApp.application.Companies.Company;
using UsersApp.domain.Persistence.Companies;

namespace UserApp.api.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll(string username, string password, [FromServices] ICompanyUnitOfWork unitOfWork)
        {

            var requestHandler = new GetAllCompaniesRequestHandler(unitOfWork);
            requestHandler.SetUserData(username, password);
            var result = await requestHandler.ProcessActiveRequestAsnync(new GetAllCompaniesRequest());
            return result.ToActionResult(this);


        }

        
    }
}
