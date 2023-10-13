
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcDoll.Data;
using System;
using System.Linq;

namespace MvcDoll.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcDollContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcDollContext>>());
            // Look for any Doll.
            if (context.Doll.Any())
            {
                return;
            }
            context.Doll.AddRange(

                new Doll
                {
                    Name = "Blossom",
                    Categories = "Paper Doll",
                    Firstlaunch = DateTime.Parse("1990-08-04"),
                    Brand = "American Girl", // Based on cartoon theme
                    Price = 75.85M,
                    Rating ="Good"
                },

               new Doll
               {
                   Name = "Ella",
                   Categories = "Action Doll",
                   Firstlaunch = DateTime.Parse("1997-07-04"),
                   Brand = "Hosbro", // Speaks spanish and french
                   Price = 76.89M,
                   Rating = "Excellent"
               },

                 new Doll
                 {
                     Name = "Lilly",
                     Categories = "Puppet",
                     Firstlaunch = DateTime.Parse("1966-09-04"),
                     Brand = "Mattel",
                     Price = 123.99M,
                     Rating = "well"
                 },

                 new Doll
                 {
                     Name = "Starlight",
                     Categories = "African Doll",
                     Firstlaunch = DateTime.Parse("1975-08-04"),
                     Brand = "Corolle",
                     Price = 90.99M,
                     Rating = "Good"
                 },
                 new Doll
                 {
                     Name = "Starlyne",
                     Categories = "Corn Husk Doll",
                     Firstlaunch = DateTime.Parse("1955-11-04"),
                     Brand = "Barbie",
                     Price = 77.99M,
                     Rating = "Awesome"
                 },
                 new Doll
                 {
                     Name = "Trinity",
                     Categories = "China Doll",
                     Firstlaunch = DateTime.Parse("1985-04-04"),
                     Brand = "Truly Me",
                     Price = 87.99M,
                     Rating = "VeryGood"
                 },
                 new Doll
                 {
                     Name = "Victoria",
                     Categories = "sdf",
                     Firstlaunch = DateTime.Parse("1988-11-04"),
                     Brand = "Baby Alive",
                     Price = 175.99M,
                     Rating = "Awesome"
                 },
                 new Doll
                 {
                     Name = "Rainbow",
                     Categories = "Reborn Doll",       // Lovely doll that needs being cuddled just like the real one Cute......
                             Firstlaunch = DateTime.Parse("2000-04-04"),
                     Brand = "Jc Toys",
                     Price = 123.99M,
                     Rating = "Awesome+"
                 },
                 new Doll
                 {
                     Name = "Maya",
                     Categories = "Matryoshka Doll",
                     Firstlaunch = DateTime.Parse("2023-09-04"),
                     Brand = "Disney ",
                     Price = 73.99M,
                     Rating = "A"
                 },
                 new Doll
                 {
                     Name = "Krissie",
                     Categories = "Bisque Doll",
                     Firstlaunch = DateTime.Parse("2023-09-04"),
                     Brand = "Nicklelodeon",    // christmas Holiday Dolls
                     Price = 97.99M,
                     Rating = "A++"
                 },
                new Doll
                {
                    Name = "Liliana",
                    Categories = "Hopi Kachina Doll",
                    Firstlaunch = DateTime.Parse("2023-09-04"),
                    Brand = "Cocomelon",      // toys for preschoolers
                    Price = 63.98M,
                    Rating = "B"
                }

            );
            context.SaveChanges();
        }
        }
    }

