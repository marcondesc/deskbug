using Microsoft.EntityFrameworkCore;
using Deskbug.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Internal;

namespace Deskbug.EntityConfigs;

public class UserEntityConfig : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("bigint");

        builder.Property(x => x.FullName)
            .HasColumnName("full_name")
            .HasColumnType("nvarchar(150)")
            .IsRequired();

        builder.Property(x => x.UserName)
            .HasColumnName("user_name")
            .HasColumnType("nvarchar(50)")
            .IsRequired();

        builder.Property(x => x.Password)
            .HasColumnName("password")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnName("email")
            .HasColumnType("nvarchar(150)")
            .IsRequired();

        builder.Property(x => x.Token)
            .HasColumnName("token")
            .HasColumnType("nvarchar(150)");

        builder.Property(x => x.TokenDate)
            .HasColumnName("token_date")
            .HasColumnType("DateTime");

        builder.Property(x => x.UserStatus)
            .HasColumnName("user_status")
            .HasColumnType("int")
            .IsRequired();
    }


}