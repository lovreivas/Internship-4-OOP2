using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Common.Validation.ValidationItems;

namespace UsersApp.domain.Entities
{
    public class User
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

        public bool IsActive { get; set; } = true;

        public const int NameMaxLength = 100;
        public const int AddressStreetMaxLength = 150;
        public const int AddressCityMaxLength = 100;
        public const int WebsiteMaxLength = 100;

        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }

        private bool IsValidURL(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }

        public async Task<Result<bool>> Create(IUserRepository userRepository)
        {
            var validationResult = await CreateOrUpdateValidation();
            if (validationResult.HasError)
            {
                return new Result<bool>(false, validationResult);
            }

            await userRepository.InsertAsync(this);

            return new Result<bool>(true, validationResult);


        }
        public async Task<Common.Validation.ValidationResult> CreateOrUpdateValidation()
        {
            var validationResult = new Common.Validation.ValidationResult();
            if (Name?.Length > NameMaxLength)
                validationResult.AddValidationItem(ValidationItems.User.NameMaxLength);

            if (!string.IsNullOrEmpty(Email) && !IsValidEmail(Email))
                validationResult.AddValidationItem(ValidationItems.User.EmailValid);

            if (!string.IsNullOrWhiteSpace(Website))
            {
                if (Website.Length > WebsiteMaxLength)
                    validationResult.AddValidationItem(ValidationItems.User.WebsiteMaxLength);

                if (!IsValidURL(Website))
                    validationResult.AddValidationItem(ValidationItems.User.WebsiteValidUrlPattern);
            }



            return validationResult;
        }
    }
}
