using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EntityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Data.DBContext
{
    public class ApplicationDbContext: IdentityDbContext<UserModel>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EntityModel.UserModel> User { get; set; }

        public DbSet<EntityModel.EventModel> Event{ get; set; }

        public DbSet<EntityModel.CommentModel> Comment { get; set; }

        public DbSet<EntityModel.SignInUserModel> SignIn { get; set; }

        public DbSet<EntityModel.SignUpUserModel> SignUp { get; set; }
    }
}
