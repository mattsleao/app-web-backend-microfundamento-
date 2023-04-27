﻿using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
