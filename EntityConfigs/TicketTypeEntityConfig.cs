using Deskbug.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deskbug.EntityConfigs;

public class TicketTypeEntityConfig : IEntityTypeConfiguration<TicketType>
{
    public void Configure(EntityTypeBuilder<TicketType> builder)
    {
        builder.ToTable("ticket_type");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasColumnType("nvarchar(150)")
            .IsRequired();

        builder.Property(x => x.TicketTypeStatus)
            .HasColumnName("ticket_type_status")
            .HasColumnType("int")
            .IsRequired();
    }

}