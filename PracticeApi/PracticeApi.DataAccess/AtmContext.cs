using Microsoft.EntityFrameworkCore;
using PracticeApi.Entities;
using System;

namespace PracticeApi.DataAccess
{
    public class AtmContext:DbContext 
    {
        //public AtmContext() { }
        public AtmContext(DbContextOptions<AtmContext> options)
            : base(options)
        { 
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bank> Banks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Transaction>()
            //.HasOne<Bank>()
            //.WithMany(b => b.Transactions).OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Transaction>()
            //    .HasOne<Customer>()
            //    .WithMany(c => c.Transactions).OnDelete(DeleteBehavior.SetNull);
        }
        

    }
}
