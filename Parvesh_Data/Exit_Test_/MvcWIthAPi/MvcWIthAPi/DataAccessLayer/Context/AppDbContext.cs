using Microsoft.EntityFrameworkCore;
using MvcWIthAPi.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcWIthAPi.DataAccessLayer.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Camp> Camps { get; set; }

        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Camp>().ToTable("Camps");
            modelBuilder.Entity<Book>().ToTable("Books");
        }
    }
    
}
