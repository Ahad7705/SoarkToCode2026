using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject
{
    public class ProjectContext : DbContext //oop inhertance
    {

        // 1- Register Models

        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> Departmants { get; set; }
        public DbSet<Projectcs> projects { get; set; }

        public DbSet<Dependent> dependents { get; set; }

        public DbSet<WorkOn> WorksOns { get; set; }

        // 2- Connect To Database

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
        @"Server=.\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;"
    );
        }
    }
}
