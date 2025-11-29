using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Validation.ValidationItems
{
    public static class ValidationItems
    {
        public static class User
        {
            public static string CodePrefix = nameof(User);

            public static readonly ValidationItem NameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}_1",
                Message = $"Ime prelazi maksimalnu dopuštenu duljinu ({Entities.User.NameMaxLength}).",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem UsernameUnique = new ValidationItem
            {
                Code = $"{CodePrefix}_2",
                Message = $"Korisničko ime mora biti jedinstveno.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailUnique = new ValidationItem
            {
                Code = $"{CodePrefix}_3",
                Message = $"Email adresa mora biti jedinstvena.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem EmailValid = new ValidationItem
            {
                Code = $"{CodePrefix}_4",
                Message = $"Unesite ispravnu email adresu (npr. korisnik@example.com).",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}_5",
                Message = $"Web stranica prelazi maksimalnu dopuštenu duljinu ({Entities.User.WebsiteMaxLength}).",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteValidUrlPattern = new ValidationItem
            {
                Code = $"{CodePrefix}_6",
                Message = $"Unesite ispravan URL.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AlreadyActive = new ValidationItem
            {
                Code = $"{CodePrefix}_7",
                Message = "Korisnik je već aktivan.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.BusinessRule
            };

            public static readonly ValidationItem AlreadyInactive = new ValidationItem
            {
                Code = $"{CodePrefix}_8",
                Message = "Korisnik je već neaktivan.",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.BusinessRule
            };
        }
    }


}
