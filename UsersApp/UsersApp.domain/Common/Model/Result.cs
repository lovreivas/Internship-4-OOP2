using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.domain.Common.Model
{
    public class Result
    {
        public TValue Value { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public Result(TValue value, ValidationResult validationResult)
        {
            Value = value;
            ValidationResult = validationResult;
        }
    }
}
