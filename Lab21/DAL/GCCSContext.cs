using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Lab21.Models;

namespace Lab21.DAL
{
    public class GCCSContext : DbContext
    {
        public GCCSContext() : base("GCCSContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}