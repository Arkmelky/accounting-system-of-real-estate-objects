using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DbModels;

namespace DataAccess
{
    public class DB_Context : DbContext
    {
        public DB_Context() : base("RieltDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ObjectOfTransaction> ObjectOfTransactions { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
