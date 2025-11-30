using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common.Model;
using UserApp.application.DTOs.Users;
using UsersApp.domain.Persistence.Users;

namespace UserApp.application.Users.User
{
    public class GetByIdUserRequest
    {
        public int Id { get; init; }
        public GetByIdUserRequest(int id)
        {
            Id = id;
        }
    }
    public class GetByIdUserRequestHandler : RequestHandler<GetByIdUserRequest, UserDto>
    {
        private readonly IUserUnitOfWork _unitOfWork;
        public GetByIdUserRequestHandler(IUserUnitOfWork userUnitOfWork)
        {
            _unitOfWork = userUnitOfWork;
        }

        protected async override Task<Common.Model.Result<UserDto>> HandleRequest(GetByIdUserRequest request, Common.Model.Result<UserDto> result)
        {
            var user = await _unitOfWork.Repository.GetById(request.Id);
            UserDto dto = UserDto.FromEntity(user);
            if (dto != null)
                result.SetResult(dto);
            return result;


        }

        protected override Task<bool> IsActive()
        {
            return Task.FromResult(true);
        }
    }
}
