﻿using ERPSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ERPSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
