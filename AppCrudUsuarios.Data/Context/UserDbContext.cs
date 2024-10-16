using AppCrudUsuarios.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppCrudUsuarios.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("Users");
            base.OnModelCreating(modelBuilder);
        }
    }
}
