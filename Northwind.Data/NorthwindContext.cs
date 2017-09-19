﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name=NW") // name of the <connectionString><add name=""......
        {
            // since EF6 (by default) will want to create a database if it can't find it,
            // we can turn that feature off programmatically in our DbContext constructor.

            Database.SetInitializer<NorthwindContext>(null);
        }

        // Properties
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        // Override base class method that does the details of mapping entities to the database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Here I could have a whole lot more control over how each entity maps out to the database tables 
            base.OnModelCreating(modelBuilder);
        }
    }
}