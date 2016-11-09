using ParseNytElection2016.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNytElection2016.Data
{
    public class Election2016Context : DbContext
    {
        public Election2016Context(string connectionString)
            : base(connectionString)
        {
            // Do not attempt to create database
            Database.SetInitializer<Election2016Context>(null);
        }

        public DbSet<CountyResult> CountyResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // table names are not plural in DB, remove the convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
