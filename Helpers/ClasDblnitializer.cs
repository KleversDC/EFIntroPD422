using EFIntroPD422.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFIntroPD422.Helpers

{

    static class DbInitializer

    {

        public static void SeedAirplanes(this ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Airplane>().HasData(new Airplane[]
            {

                new Airplane { Id = 1, Model = "Boeng 747", MaxPassengers = 140},

                new Airplane { Id = 2, Model = "Airbus A320", MaxPassengers = 130},

                new Airplane { Id = 3, Model = "Boeng 737", MaxPassengers = 120},

                new Airplane { Id = 4, Model = "Airbus A380", MaxPassengers = 150}

            });

        }

        public static void SeedClients(this ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Client>().HasData(new Client[]
            {

                new Client {Id = 1, Name = "Ivan", Email = "ivan@gmail.com", Birthdate = new DateTime(1990, 1, 1)},

                new Client {Id = 2, Name = "Petro", Email = "petro@gmail.com", Birthdate = new DateTime(1992, 10, 10)},

                new Client {Id = 3, Name = "Vasyl", Email = "vasyl@gmail.com", Birthdate = new DateTime(1995, 5, 5)},

                new Client {Id = 4, Name = "Oleg", Email = "oleg@gmail.com", Birthdate = new DateTime(1998, 12, 12)},

                new Client {Id = 5, Name = "Olena", Email = "olena@gmail.com", Birthdate = new DateTime(2000, 6, 6)},

            });

        }

        public static void SeedFlights(this ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Flight>().HasData(new Flight[]
            {

                new Flight { Id = 1, DepartureTime = new DateTime(2021, 10, 10, 10, 10, 10), ArrivalTime = new DateTime(2021, 10, 10, 12, 10, 10), Rating = 4.5, AirplaneId = 1, DepartureCity = "Kyiv", ArrivalCity = "Lviv"},

                new Flight { Id = 2, DepartureTime = new DateTime(2021, 10, 11, 11, 11, 11), ArrivalTime = new DateTime(2021, 10, 11, 13, 11, 11), Rating = 4.0, AirplaneId = 2, DepartureCity = "Lviv", ArrivalCity = "Kyiv"},

                new Flight { Id = 3, DepartureTime = new DateTime(2021, 10, 12, 12, 12, 12), ArrivalTime = new DateTime(2021, 10, 12, 14, 12, 12), Rating = 4.3, AirplaneId = 3, DepartureCity = "Kyiv", ArrivalCity = "Odesa"},

                new Flight { Id = 4, DepartureTime = new DateTime(2021, 10, 13, 13, 13, 13), ArrivalTime = new DateTime(2021, 10, 13, 15, 13, 13), Rating = 4.7, AirplaneId = 4, DepartureCity = "Odesa", ArrivalCity = "Kyiv"},

            });

        }

    }

}

