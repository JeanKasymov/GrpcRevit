using GrpcWpf.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace GrpcWpf.Services
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<Family> Families { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RevitURS;Username=postgres;Password=pass");
        }
    }
}
