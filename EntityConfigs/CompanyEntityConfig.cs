using Deskbug.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deskbug.EntityConfigs;

public class CompanyEntityConfig : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("company");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasColumnType("nvarchar(150)")
            .IsRequired();

        builder.Property(x => x.ShortName)
            .HasColumnName("short_name")
            .HasColumnType("nvarchar(50)")
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("description")
            .HasColumnType("nvarchar(MAX)")
            .IsRequired();

        builder.Property(x => x.CreatedDate)
            .HasColumnName("created_date")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(x => x.CompanyStatus)
            .HasColumnName("company_status")
            .HasColumnType("int")
            .IsRequired();
    }

}