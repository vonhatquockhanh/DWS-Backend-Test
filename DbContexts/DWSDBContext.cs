using APIDWS.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDWS.DbContexts {
    public class DWSDBContext : DbContext {

        public DWSDBContext (DbContextOptions<DWSDBContext> opt) : base (opt) {

        }

        // public DbSet<Command> Commands { get; set; }
        public DbSet<User> Users { get; set; }

        // Keys
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            // User Model
            modelBuilder.Entity<User> ()
                .HasIndex (user => user.Email)
                .IsUnique ();
            modelBuilder.Entity<User> ()
                .HasIndex (user => user.PhoneNo)
                .IsUnique ();
            modelBuilder.Entity<User> ()
                .HasIndex (user => user.UserName)
                .IsUnique ();
        }
    }
}