using EFIntroPD422.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFIntroPD422
{
    class AirLinesDbContext: DbContext
    {
        public AirLinesDbContext()
        {
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yroksk;Integrated Security=True;Connect Timeout=6;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(new Client[]
            {
                new Client {Id = 1, Name = "Ivan", Email = "ivan@gmail.com", Birthdate = new DateTime(1990, 1, 1)},
                new Client {Id = 2, Name = "Petro", Email = "petro@gmail.com", Birthdate = new DateTime(1992, 10, 10)},
                new Client {Id = 3, Name = "Vasyl", Email = "vasyl@gmail.com", Birthdate = new DateTime(1995, 5, 5)}
            });
            modelBuilder.Entity<Airplane>().Property(a => a.Model).IsRequired();
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Client>().Property(C => C.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Client>().ToTable("FirstName");
            modelBuilder.Entity<Flight>().HasOne(f => f.Airplane).WithMany(a => a.Flights).HasForeignKey(f => f.AirplaneId);
        }


        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
    }
}
