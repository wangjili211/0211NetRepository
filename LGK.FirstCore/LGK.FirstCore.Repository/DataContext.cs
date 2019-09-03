﻿using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LGK.FirstCore.Repository
{
    public class DataContext : DbContext
    {

        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> UserModelset { get; set; }
        public DbSet<Role> RoleModelset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=127.0.0.1;Initial Catalog=projectmanage;User ID=root;pwd=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}