using BankingApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Contexts
{
   public class BankingContext:DbContext
    {

        public BankingContext() { }
        public BankingContext(DbContextOptions<BankingContext> dbContextOptions) : base(dbContextOptions) { 
        
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConn"));

            }
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Address> Addresses { get; set; }

       
    }
}
