using CentricTeam13.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CentricTeam13.DAL
{
    public class context : DbContext
    {
        public context() : base("name=cs4200")
        { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}