using System;
using Handler_Yapisi_deneme.Entities;
using Microsoft.EntityFrameworkCore;

namespace Handler_Yapisi_deneme.Context
{
    public class APPContext: DbContext
    {
        public APPContext(DbContextOptions<APPContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}