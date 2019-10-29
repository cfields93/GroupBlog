using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupBlog.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public bool Approved { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> Errors = new List<ValidationResult>();
            if (string.IsNullOrEmpty(Title))
            {
                Errors.Add(new ValidationResult("Title is required.", new[] { "Title" }));
            }
            if (string.IsNullOrEmpty(Body))
            {
                Errors.Add(new ValidationResult("Body is required.", new[] { "Body" }));
            }
            return Errors;
        }
    }
}