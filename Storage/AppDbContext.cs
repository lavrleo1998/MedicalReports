using Domain;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Storage
{
    public class AppDbContext : DbContext
    {
        public DbSet<Param> Params { get; set; }
        public DbSet<Template> Templates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"ConnectionString.txt";
            //string connectionString = "Server=LAVRLEO-HP\\SQLEXPRESS;Database=MedicalReportsBD;Trusted_Connection=True;";
            string connectionString = "";

            using (StreamReader sr = new StreamReader(path))
            {

                connectionString = sr.ReadToEnd();
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
