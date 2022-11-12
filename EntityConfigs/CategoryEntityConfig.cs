using Microsoft.EntityFrameworkCore;
using Deskbug.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Internal;

namespace Deskbug.EntityConfigs;

public class CategoryEntityConfig : IEntityTypeConfiguration<Category>
{

    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("category");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(x => x.DisplayOrder)
            .HasColumnName("display_order")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(x => x.CategoryLevel)
            .HasColumnName("category_level")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(x => x.CategoryReference)
            .HasColumnName("category_reference")
            .HasColumnType("int");

        builder.Property(x => x.CreatedDate)
            .HasColumnName("created_date")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(x => x.CategoryStatus)
            .HasColumnName("category_status")
            .HasColumnType("int")
            .IsRequired();
    }

}
