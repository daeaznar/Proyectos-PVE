using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tools
{
    public class ModelValidation<T> where T : class
    {
        public List<ValidationResult> Validate(T item)
        {
            var context = new ValidationContext(item);
            var errors = new List<ValidationResult>();
            Validator.TryValidateObject(item, context, errors, true);
            return errors;
        }
    }
}
