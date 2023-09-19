using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWIthAPi.PresentationLayer.Models
{
    public class Admin
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
        
    }
}
