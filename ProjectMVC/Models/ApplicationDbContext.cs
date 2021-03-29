using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ProjectMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            :base("Model1")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
       // public virtual DbSet<VehicleMake> VehicleMake { get; set; }
        //public virtual DbSet<VehicleModel> VehicleModel { get; set; }
    }
}