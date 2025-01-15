using geometric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace geometric.Repositories.Config
{
    public class GeometricConfig : IEntityTypeConfiguration<Geometric>
    {
        public void Configure(EntityTypeBuilder<Geometric> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(g => g.Geometry)
                .HasColumnType("geometry")
                .IsRequired();
        }
    }
}
