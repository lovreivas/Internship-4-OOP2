using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Validation
{
    public class ValidationResult
    {
        private List<ValidationItem> _validationItems = new List<ValidationItem>();
        public IReadOnlyList<ValidationItem> ValidationItems => _validationItems;

        public bool HasError => _validationItems.Any(validationResult => validationResult.ValidationSeverity == ValidationSeverity.Error);
        public bool HasInfo => _validationItems.Any(validationResult => validationResult.ValidationSeverity == ValidationSeverity.Information);
        public bool HasWarning => _validationItems.Any(validationResult => validationResult.ValidationSeverity == ValidationSeverity.Warning);

        public void AddValidationItem(ValidationItem validationItem)
        {
            _validationItems.Add(validationItem);
        }
    }
}
