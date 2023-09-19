using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    class SignUpModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter your firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your emailid")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter you Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
