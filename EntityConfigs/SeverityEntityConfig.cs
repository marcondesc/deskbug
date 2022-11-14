using Deskbug.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deskbug.EntityConfigs;

public class SeverityEntityConfig : IEntityTypeConfiguration<Severity>
{
    public void Configure(EntityTypeBuilder<Severity> builder)
    {
        builder.ToTable("severity");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasColumnType("nvarchar(150)")
            .IsRequired();

        builder.Property(x => x.Grade)
            .HasColumnName("grade")
            .HasColumnType("int")
            .IsRequired();
    }

}