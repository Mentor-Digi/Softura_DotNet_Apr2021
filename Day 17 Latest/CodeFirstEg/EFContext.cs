using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CodeFirstEg
{
    class EFContext : DbContext
    {
        public EFContext()
        {
        }

        private const string connectionString = "Server=.;Database=SofturaCF;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                    optionsBuilder.UseSqlServer(connectionString);
        }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        }
    }


