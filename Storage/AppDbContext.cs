using Storage.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(): base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasRequired(c => c.Role)
                .WithOptional(c => c.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}
