using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantTracker.Models;

namespace RestaurantTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Table> Table { get; set; }
        public DbSet<Waiter> Waiter { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Waiter>().HasData(
                new Waiter()
                {
                    Id = 1,
                    FirstName = "Steve",
                    LastName = "Adams"
                },
                   new Waiter()
                   {
                       Id = 2,
                       FirstName = "Tommy",
                       LastName = "Spurlock"
                   }
                );

            builder.Entity<Table>().HasData(
                new Table()
                {
                    Id = 1,
                    Name = "Table 1",
                    WaiterId = 1
                },
                 new Table()
                 {
                     Id = 2,
                     Name = "Table 2",
                     WaiterId = 2
                 }

            );
        }

    }
}
