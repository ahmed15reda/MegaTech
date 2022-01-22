using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechTree.Models
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="User Name")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Fisrt Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        [RegularExpression("^[1-9]{5}$")]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }
        [Required]
        [RegularExpression("^01[0-2]{1}[0-9]{8}")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } 
        public bool AcceptUserAgreement { get; set; }
        public string RegistrationInvalid { get; set; }
        public int CategoryId { get; set; }

    }
}
