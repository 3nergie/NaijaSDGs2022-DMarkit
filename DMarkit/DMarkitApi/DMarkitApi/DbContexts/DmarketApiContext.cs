using DMarkitApi.Entities;
using DMarkitApi.Enums;
using DMarkitApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.DbContexts
{
    public class DmarketApiContext : IdentityDbContext<ApplicationUser>
    {
        public DmarketApiContext(DbContextOptions<DmarketApiContext> options)
           : base(options)
        {

        }

       // public DbSet<Person> Persons { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public DbSet<Trade> Trades { get; set; }

        //protected override void OnModelCreating
        //    (ModelBuilder modelBuilder)
        //{
        //    // seed the database with dummy data
        //    modelBuilder.Entity<Person>().HasData(
        //    new Person()
        //    {
        //        Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
        //        FirstName = "Adebanjo",
        //        LastName = "Olatunji",
        //        Gender = "Mail",
        //        Password ="Olaide",
        //        ConfirmPassword = "Olaide",
        //        DateofBirth = new DateTime(2021, 10, 17),
        //        Email = "olaideadebanjo@gmail.com",
        //        ConfirmEmail = "olaideadebanjo@gmail.com",
        //        Contact = int.Parse("08026156171"),
        //        ConfirmContact = int.Parse("08026156171"),
        //    },
        //      new Person()
        //      {
        //          Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
        //          FirstName = "Adebanjo",
        //          LastName = "Oluwasola",
        //          Gender = "Mail",
        //          Password = "Olaide",
        //          ConfirmPassword = "Olaide",
        //          DateofBirth = new DateTime(2021, 10, 17),
        //          Email = "olaideadebanjo@gmail.com",
        //          ConfirmEmail = "olaideadebanjo@gmail.com",
        //          Contact = int.Parse("08026156171"),
        //          ConfirmContact = int.Parse("08026156171"),
        //      },
        //        new Person()
        //        {
        //            Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
        //            FirstName = "Adebanjo",
        //            LastName = "Arinola",
        //            Gender = "Mail",
        //            Password = "Olaide",
        //            ConfirmPassword = "Olaide",
        //            DateofBirth = new DateTime(2021, 10, 17),
        //            Email = "olaideadebanjo@gmail.com",
        //            ConfirmEmail = "olaideadebanjo@gmail.com",
        //            Contact = int.Parse("08026156171"),
        //            ConfirmContact = int.Parse("08026156171"),
        //        },
        //          new Person()
        //          {
        //              Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
        //              FirstName = "Adebanjo",
        //              LastName = "Oluwasola",
        //              Gender = "Mail",
        //              Password = "Olaide",
        //              ConfirmPassword = "Olaide",
        //              DateofBirth = new DateTime(2021, 10, 17),
        //              Email = "olaideadebanjo@gmail.com",
        //              ConfirmEmail = "olaideadebanjo@gmail.com",
        //              Contact = int.Parse("08026156171"),
        //              ConfirmContact = int.Parse("08026156171"),
        //          }
        //          );

        //    modelBuilder.Entity<Account>().HasData(
        //        new Account
        //        {
        //            Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
        //            PersonId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
        //            Nuben = "8026156171"
        //        },
        //        new Account
        //        {
        //            Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
        //            PersonId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
        //            Nuben = "8026156171"
        //        },
        //        new Account
        //        {
        //            Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
        //            PersonId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
        //            Nuben = "8026156171"
        //        },
        //        new Account
        //        {
        //            Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
        //            PersonId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
        //            Nuben = "8026156171"
        //        }
        //        );

        //    base.OnModelCreating(modelBuilder);



        //}

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Trade>().HasData(
            new Trade()
            {
                TradeId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                NameSeller = "Adebanjo olaide",
                Amount = 50000.00,
                Rate = 780.00,
                DateCreated = new DateTime(2022,10, 19),
                IsActive = true,
                CurrencyPair = TradePairEnum.EUR_NGN,

            },
            new Trade()
            {
                TradeId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                NameSeller = "Adebanjo olatunji",
                Amount = 10000.00,
                Rate = 880.00,
                DateCreated = new DateTime(2022, 10, 10),
                IsActive = false,
                CurrencyPair = TradePairEnum.GBP_NGN
            },
            new Trade()
            {
                TradeId = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                NameSeller = "Adebanjo olatunji",
                Amount = 20000.00,
                Rate = 700.00,
                DateCreated = new DateTime(2022, 10, 10),
                IsActive = false,
                CurrencyPair = TradePairEnum.JPY_NGN
            }
            );
            base.OnModelCreating(modelBuilder);  
        }
    }
}
