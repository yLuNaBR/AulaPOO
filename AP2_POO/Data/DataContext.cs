using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP2_POO.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AP2_POO.Data
{
    public class DataContext : DbContext
    {  
        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "ap2_po.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Pacient> Pacients  { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}