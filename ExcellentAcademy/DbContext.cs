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

        public DbSet<Form> Form { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>().ToTable("ExcellentAcademyStudents");
        }
    }
}
