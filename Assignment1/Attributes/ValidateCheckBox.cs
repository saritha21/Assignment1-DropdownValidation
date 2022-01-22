using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Attributes
{
    public class ValidateCheckBox : ValidationAttribute,IClientModelValidator
    {
        //serverside
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-Checkbox", ErrorMessage);
        }
        //clientside
        public override bool IsValid(object? value)
        {
            return (bool)value;
            //if ((bool)value==true)
            //        return true;
            //else
            //    return false;
        }
    }
}
