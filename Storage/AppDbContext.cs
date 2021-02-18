using Domain;
using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProtocolParameter> ProtocolParameters { get; set; }
        public DbSet<Template> Templates { get; set; }
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAVRLEO-HP\\SQLEXPRESS;Database=MedicalReportsBD;Trusted_Connection=True;");
        }
    }
} 
