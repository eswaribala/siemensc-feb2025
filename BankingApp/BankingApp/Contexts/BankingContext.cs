using BankingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Contexts
{
   public class BankingContext:DbContext
    {
        public BankingContext(DbContextOptions<BankingContext> dbContextOptions) : base(dbContextOptions) { 
        
           // this.Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Address> Addresses { get; set; }

       
    }
}
