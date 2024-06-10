using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PvhLesson08CF.Models
{
    public class PvhBookStore:DbContext
    {
        public PvhBookStore():base ("PvhBookStoreConnectionString") 
        {
        
        }
        // tao cac bang
        public DbSet<PvhCategory> PvhCategories { get; set; }
        public DbSet<Pvhbook> PvhBooks { get; set; }
    }
}