﻿using System;
using AM.CORE.DOMAIN;
using AM.Data.Configurations;
using Microsoft.EntityFrameworkCore;
namespace AM.Data
{
    public class AMContext:DbContext
    {

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
                    Initial Catalog = Airport;  
                    Integrated Security = true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
            modelBuilder.ApplyConfiguration(new PassengerConfig());
            //Tp5 Q5
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //Tp5 Q7
            modelBuilder.ApplyConfiguration(new ReservationConfig());

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date");
        }
    }
}


