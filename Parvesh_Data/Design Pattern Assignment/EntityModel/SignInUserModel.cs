using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModel
{
    public class SignInUserModel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter you emailid")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter you Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
