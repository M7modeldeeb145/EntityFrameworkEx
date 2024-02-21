using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Taskss> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
                ("Data Source=.;Initial Catalog=EFExcercise;Integrated Security=True;TrustServerCertificate=True");       
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Taskss>().Property(e=>e.Date).IsRequired();
            modelBuilder.Entity<Taskss>().ToTable("Taskes");
            modelBuilder.Entity<Taskss>().Property(e => e.Date).HasColumnName("Deadline");
        }
    }
}
