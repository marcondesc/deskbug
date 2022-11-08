using Microsoft.EntityFrameworkCore;
using Deskbug.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Internal;

namespace Deskbug.EntityConfigs;

public class ProjectEntityConfig : IEntityTypeConfiguration<Project>
{

    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("project");

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

        builder.Property(x => x.ProjectColor)
            .HasColumnName("project_color")
            .HasColumnType("nvarchar(7)");

        builder.Property(x => x.CreatedDate)
            .HasColumnName("created_date")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(x => x.ProjectStatus)
            .HasColumnName("project_status")
            .HasColumnType("int")
            .IsRequired();
    }

}