using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings{
    public class TipsMap : IEntityTypeConfiguration<TipsEntity>{
        public void Configure(EntityTypeBuilder<TipsEntity> builder){
            builder.ToTable("Tips");

            builder.HasKey(t => t.Id);
                
            builder.Property(t => t.text)
                .IsRequired();

            builder.Property(t => t.type)
                .IsRequired();

            builder.Property(t => t.Picture)
                .IsRequired();
        }
    }
}