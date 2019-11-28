using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Student.Data
{
    public class LibraryDb :DbContext
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=Library_Student;Trusted_Connection=True";
        public DbSet<CetUser> CetUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public LibraryDb() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CetUser>().HasData(
                new CetUser
                {
                    Id = 1,
                    Name = "Super",
                    Surname = "User",
                    UserName = "admin",
                    Password = new Service.CetUserService().hashPassword("admin"),
                    CreatedDate = DateTime.Now,
                    RoleName = "Admin"
                    
                }

                );

            

        }

   
    }
}
