
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.configurations;

namespace WebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<UserModel> UserModels {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>()
                .HasIndex(u => u.UserName)
                .IsUnique();
            builder.Entity<UserModel>()
                .HasIndex(u => u.UserEmail)
                .IsUnique();
            builder.ApplyConfiguration(new DrinkModelConfiguration());
        }
        public DbSet<DrinkModel> DrinkModels {get; set;}
    }
}