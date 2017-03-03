using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCApplication.Models
{
    public class MVCTest:DbContext
    {
        public DbSet<movie> Movie { get; set; }
        public DbSet<MovieType> movietype { get; set; }
        public DbSet<Customer> customer { get; set; }
        //public DbSet<MovieType> movietype { get; set; }
       // public DbSet<movie> movielist { get; set; }
    }
}