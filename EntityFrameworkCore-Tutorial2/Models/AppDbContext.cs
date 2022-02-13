using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Tutorial2.Models {

    public class AppDbContext : DbContext  {
            // from 2022-02-11 file 20220211 AM1 EFramwork audio file apple
                        //type         Property
        public virtual DbSet<BandCustomer> BandCustomers { get; set; }
        
       

        // Constructors
        public AppDbContext() { } //default constructor
        //    have to call the Parent Constuctor ..has parameter
        //                  |-----Type-------------------|
        //                  |generic Class--<need Angles>| |var name/ Call Parant constructor| 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        //----------------------Method-------overriding when Configuring is called instead
        // -----------------------------of using the other Context b/c of inheriting
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if(!builder.IsConfigured) {
                builder.UseSqlServer("server=localhost\\sqlexpress;database=SalesDb1;trusted_connection=true");
            }

        }

        //protected override void OnModelCreating(ModelBuilder builder) {
        //    builder.Entity<item>(
        //        e => e.HasIndex(x => x.Code)
        //                .IsUnique(true)
        //    );
        //}

    }
}
