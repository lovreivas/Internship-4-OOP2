using Microsoft.AspNetCore.Mvc;
using UserApp.api.Common;
using UserApp.application.Common;
using UserApp.application.Users.User;
using UsersApp.domain.Persistence.Users;

namespace UserApp.api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById([FromServices] IUserUnitOfWork unitOfWork, [FromRoute] int id)
        {

            var requestHandler = new GetByIdUserRequestHandler(unitOfWork);
            var result = await requestHandler.ProcessActiveRequestAsnync(new GetByIdUserRequest(id));
            return result.ToActionResult(this);


        }
    


    }
}
