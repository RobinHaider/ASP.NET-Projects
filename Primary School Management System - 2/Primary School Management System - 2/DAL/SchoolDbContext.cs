using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Primary_School_Management_System___2.Models;

namespace Primary_School_Management_System___2.DAL
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Result> Results { get; set; }

        public SchoolDbContext():base("SchoolDbcontext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //may cause cycles or multiple cascade paths  Specify ON DELETE NO ACTION or ON UPDATE NO ACTION
            //modelBuilder.Entity<Result>()
            //    .HasOptional(s => s.Subject)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);


            //configaring Class and teacher zero or one to one relation
            //modelBuilder.Entity<Class>()
            //    .HasOptional(s => s.Teacher)
            //    .WithOptionalDependent(t => t.Class);
        }
    }
}