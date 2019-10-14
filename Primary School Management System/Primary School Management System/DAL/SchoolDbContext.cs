using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Primary_School_Management_System.Models;

namespace Primary_School_Management_System.DAL
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        //public DbSet<Result> Results { get; set; }

        public SchoolDbContext():base("SchoolDbContext2")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder
            //    .Entity<Result>()
            //    .HasOptional(e => e.Subject)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }
    }
}