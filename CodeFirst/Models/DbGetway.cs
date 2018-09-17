using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CFUsingEF.Models
{
    public class DbGetway : DbContext
    {
        public DbGetway()
            : base("CodeFirstDb")
        {
            Database.SetInitializer<DbGetway>(new CreateDatabaseIfNotExists<DbGetway>());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {

            mb.Entity<Employee>().HasKey(x => x.EmployeeId);
            mb.Entity<Employee>().Property(x => x.EmployeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mb.Entity<Employee>().HasOptional(x => x.Departments).WithMany().HasForeignKey(x => x.DepartmentId);

            mb.Entity<Department>().HasKey(x => x.DepartmentId);
            mb.Entity<Department>().Property(x => x.DepartmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            base.OnModelCreating(mb);
        }
    }
}