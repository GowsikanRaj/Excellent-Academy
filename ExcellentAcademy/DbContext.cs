using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class ExcellentAcademyContext : DbContext
    {
        public ExcellentAcademyContext(DbContextOptions<ExcellentAcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Form { get; set; }
        public DbSet<FormForDatabase> FormForDatabases { get; set; }
        public DbSet<Days> Days { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().ToTable("Student");
            modelBuilder.Entity<FormForDatabase>().ToTable("Form");
            modelBuilder.Entity<Days>().ToTable("Days");
            modelBuilder.Entity<Subjects>().ToTable("Subjects");
        }
    }
}
