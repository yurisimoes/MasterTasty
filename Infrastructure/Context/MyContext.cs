using Core.Entities;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context{
    public class MyContext : DbContext{
        public DbSet<UserEntity> Users{ get; set; }
        public DbSet<TipsEntity> Tips{ get; set; }
        public DbSet<FoodEntity> Food{ get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options){ }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<TipsEntity>(new TipsMap().Configure);
            modelBuilder.Entity<FoodEntity>(new FoodMap().Configure);
        }
    }
}