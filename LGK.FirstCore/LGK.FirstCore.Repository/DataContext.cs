﻿using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using LGK.FirstCore.Model;
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
        public DbSet<Userss> UserModelset { get; set; }
        public DbSet<Role> RoleModelset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=10.31.54.24;Initial Catalog=fortefortissimo;User ID=Yi;pwd=1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
