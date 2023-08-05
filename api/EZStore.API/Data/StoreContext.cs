using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EZStore.API.Data
{
    public class StoreContext : DbContext

    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            
        }
    }
}