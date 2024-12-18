﻿using Microsoft.EntityFrameworkCore;
using SEBOOK.Shared.Entitis;

namespace SEBOOK.Bakend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Country> countrys { get; set; }
    }
}