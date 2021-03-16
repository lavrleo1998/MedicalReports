﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class AppDbContext : DbContext
    {
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Organ> Organs { get; set; }
        public DbSet<Param> Params { get; set; }
        public DbSet<Template> Templates { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //универсальный метод
            //optionsBuilder.UseSqlServer(ConectionStringKOSTIL.NewConectionString());

            //метод для моего компа
            optionsBuilder.UseSqlServer("Server=LAVRLEO-HP\\MEDICALSERVER;Database=MedicalReportsBD;Trusted_Connection=True;");

            //метод для другого компа
            //optionsBuilder.UseSqlServer("Server=DESKTOP-F54VIOJ\\SQLEXPRESS;Database=MedicalReportsBD;Trusted_Connection=True;");
        }
    }
}
