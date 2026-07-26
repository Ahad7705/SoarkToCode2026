using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {
        // Register Models

        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<Project> projects { get; set; }

        public DbSet<Dependent> dependents { get; set; }

        public DbSet<empProj> empProjs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.D)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.supervisor)
                .WithMany(e => e.supervisee)
                .HasForeignKey(e => e.SupervisorID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
