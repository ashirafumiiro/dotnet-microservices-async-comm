﻿using Microsoft.EntityFrameworkCore;
using ProductUser.Models;

namespace ProductUser.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<ProductOfferDetail> ProductOffers { get; set; }
    }
}
