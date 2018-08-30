using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PCPartCrawler.Entity;

namespace PCPartCrawler.Context
{
    class PCPartContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=pcpartpickervn; Username=bak; Password=0");
        }

        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Price<Object>> Prices { get; set; }
    }
}
