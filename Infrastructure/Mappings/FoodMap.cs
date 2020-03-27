using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings{
    public class FoodMap : IEntityTypeConfiguration<FoodEntity>{
        public void Configure(EntityTypeBuilder<FoodEntity> builder){
            builder.ToTable("Food");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Ingredients)
                .IsRequired();

            builder.Property(f => f.Category)
                .IsRequired();

            builder.Property(f => f.Comment);

            builder.Property(f => f.Genre)
                .IsRequired();

            builder.Property(f => f.Preparation)
                .IsRequired();

            builder.Property(f => f.Picture)
                .IsRequired();
        }
    }
}