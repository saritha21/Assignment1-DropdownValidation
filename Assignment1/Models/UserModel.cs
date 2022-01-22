
using Assignment1.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Confirm Password dosen't match")]
        public string ConfirmPassword { get; set; }
        //[RegularExpression("^[789]\\d{9}$", ErrorMessage = "Please Enter Correct Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public Countries Country { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public Cities? City { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public Gender Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }

    }

    public enum Cities
    {
        Hyderabad,
        Mumbai,
        Channai,
        Bangalore
    }

    public enum Countries
    {
        India,
        USA,
        Canada,
        Australia,
        Russia
    }

    public enum Gender
    {
        Male,
        Female
    }
}