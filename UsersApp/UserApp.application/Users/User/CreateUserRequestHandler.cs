using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common.Model;
using UsersApp.domain.Entities;
using UsersApp.domain.Persistence.Users;

namespace UserApp.application.Users.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public double GeoLat { get; set; }
        public double GeoLng { get; set; }
        public string? Website { get; set; }
        public string Password { get; set; }

    }
    public class CreateUserRequestHandler : RequestHandler<CreateUserRequest, SuccessPostResponse>
    {
        private readonly IUserUnitOfWork _unitOfWork;
        public CreateUserRequestHandler(IUserUnitOfWork userUnitOfWork)
        {
            _unitOfWork = userUnitOfWork;
        }
        protected async override Task<Result<SuccessPostResponse>> HandleRequest(CreateUserRequest request, Result<SuccessPostResponse> result)
        {
            var user = new UserApp.domain.Entities.User
            {
                Name = request.Name,
                Username = request.Username,
                Email = request.Email,
                AddressStreet = request.AddressStreet,
                AddressCity = request.AddressCity,
                Website = request.Website,
                Password = request.Password,
                GeoLng = request.GeoLng,
                GeoLat = request.GeoLat


            };
            var validationResult = await user.Create(_unitOfWork.Repository);
            result.SetValidationResult(validationResult.ValidationResult);
            if (result.HasError)
                return result;
            await _unitOfWork.SaveAsync();
            result.SetResult(new SuccessPostResponse(user.Id));
            return result;
        }

        protected override Task<bool> IsActive()
        {
            return Task.FromResult(true);
        }
    }
}
