using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace EntityModel
{
    [Table("AspNetUsers")]
    public class UserModel :IdentityUser
    {
        public string Name { get; set; }
    }
}
