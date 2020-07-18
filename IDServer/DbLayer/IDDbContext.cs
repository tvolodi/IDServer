using IDServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer.DbLayer
{
    public class IDDbContext : DbContext
    {
        public IDDbContext(DbContextOptions<IDDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseNpgsql("Host=localhost;Database=ids;Username=postgres;Password=VolWork1");

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().
                HasQueryFilter(s => !s.IsDeleted);
        }
    }
}
