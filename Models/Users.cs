using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupBlog.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> Errors = new List<ValidationResult>();
            if (string.IsNullOrEmpty(Name))
            {
                Errors.Add(new ValidationResult("Name is required.", new[] { "Name" }));
            }
            if (string.IsNullOrEmpty(Email))
            {
                Errors.Add(new ValidationResult("Email is required.", new[] { "Email" }));
            }
            if (string.IsNullOrEmpty(Password))
            {
                Errors.Add(new ValidationResult("Password is required.", new[] { "Password" }));
            }
            return Errors;
        }
    }
}